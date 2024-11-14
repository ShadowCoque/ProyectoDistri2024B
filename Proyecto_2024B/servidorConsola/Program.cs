using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using static System.Collections.Specialized.BitVector32;
using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace servidorConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definición del socket para espera de conexiones
            int puerto = 8000;
            TcpListener servidor = new TcpListener(IPAddress.Any, puerto);
            Console.WriteLine("El servidor está escuchando en el puerto " + puerto);
            servidor.Start();

            while (true)
            {
                TcpClient cliente = servidor.AcceptTcpClient();
                Console.WriteLine("Usuario conectado");

                //Hilo independiente separado para manejar multiples clientes
                Thread clienteThread = new Thread(() => manejoCliente(cliente));
                clienteThread.Start();
            }

            async void manejoCliente(TcpClient cliente)
            {
                byte[] bufferRx = new byte[1024];
                NetworkStream flujo = cliente.GetStream();
                
                do
                {
                    int bytesLeidos = await flujo.ReadAsync(bufferRx, 0, bufferRx.Length);
                    if (bytesLeidos == 0)
                    {
                        break;
                    }
                    string solicitud = Encoding.ASCII.GetString(bufferRx, 0, bytesLeidos);
                    Console.WriteLine("Solicitud recibida");
                    string respuesta = "";
                    
                    //Para separar metodo y parametros
                    string[] partes = solicitud.Split('|'); //pto de parada
                    string metodo = partes[0];

                    //Condicional para el metodo correspondiente con sus respectivos parametros
                    if(metodo== "busquedaEstacion")
                    {
                        string parametroSector = partes[1];
                        List<string> estaciones = busquedaEstacion(parametroSector);
                        string stringEstaciones = "";
                        foreach (string estacion in estaciones)
                        {
                            
                            stringEstaciones = stringEstaciones + estacion + "|";
                            respuesta = stringEstaciones.Remove(stringEstaciones.Length - 1);
                        }
                        
                    }
                    if(metodo == "tengoLuz")
                    {
                        TimeSpan parametroHoraCliente = TimeSpan.Parse(partes[1]);
                        string parametroEstacion = partes[2];
                        respuesta = tengoLuz(parametroHoraCliente, parametroEstacion);
                    }
                    if (metodo == "busquedaHorario")
                    {
                        string estacion = partes[1];
                        respuesta = busquedaHorario(estacion);
                    }

                    byte[] bufferTx = Encoding.ASCII.GetBytes(respuesta);
                    await flujo.WriteAsync(bufferTx, 0, bufferTx.Length);
                    
                }while (true);
                cliente.Close();
                Console.WriteLine("Cliente Desconectdo");
            }

            //Metodo de afirmacion o negacion de si tiene luz el cliente mediante su hora y su estacion
            string tengoLuz(TimeSpan horaCliente, string estacion)
            {
                // Conexión a la base de datos
                SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProgramacionCortesDeLuz;Integrated Security=True;");
                using (connection)
                {
                    try
                    {
                        connection.Open();
                        Console.WriteLine("Verificando datos...");
                        //Se define el comando con su conexion a la bdd
                        SqlCommand cmd = new SqlCommand("VerificarDisponibilidadLuz", connection);
                        //Se define su tipo (Procedimiento Almacenado)
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        // Se definen los parámetros en caso de haberlos
                        cmd.Parameters.AddWithValue("@HoraCliente", horaCliente);
                        cmd.Parameters.AddWithValue("@Estacion", estacion);
                        //Se configura un parámetro de salida para el procedimiento almacenado
                        SqlParameter tieneLuzParam = new SqlParameter("@TieneLuz", SqlDbType.VarChar, 100)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        //Se pasa el parámetro tieneLuz al proc. almacenado
                        cmd.Parameters.Add(tieneLuzParam);
                        //Se ejecuta el procedimiento
                        cmd.ExecuteNonQuery();
                        //Se obtiene el valor del parámetro de salida
                        string tieneLuz = (string)tieneLuzParam.Value;
                        connection.Close();
                        return tieneLuz;
                    }
                    catch (Exception ex) { 
                        Console.WriteLine(ex.Message);
                        return "Error inesperado...";
                    }
                }
                    


            }// fin TengoLuz

            //Metodo de busqeuda de estacion por sector
            List<string> busquedaEstacion(string sector)
            {
                // Conexión a la base de datos
                SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProgramacionCortesDeLuz;Integrated Security=True;");
                List<string> subestaciones = new List<string>(); // Lista para almacenar los resultados
                using (connection)
                {
                    try
                    {
                        connection.Open();
                        Console.WriteLine("Buscando en la base de datos...");
                        //Se define el comando con su conexion a la bdd
                        SqlCommand cmd = new SqlCommand("BuscarSubestacionPorSector", connection);
                        //Se define su tipo (Procedimiento Almacenado)
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        // Se definen los parámetros en caso de haberlos
                        cmd.Parameters.AddWithValue("@Sector", sector);
                        //Se ejecuta y se lee el comando con SqlReader
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            Console.WriteLine("Subestaciones Encontradas: ");
                            while (reader.Read())
                            {
                                //Se imprime en consola las subestaciones encontradas y se las almacena en una lista de string
                                Console.WriteLine($"- {reader["subestacion"]}");
                                string subestacion = reader["subestacion"].ToString();
                                subestaciones.Add(subestacion);
                            }
                            connection.Close();
                        }
                        else
                        {
                            Console.WriteLine("No se encontraron subestaciones");
                            string subestacion = "No se encontraron subestaciones para este sector";
                            subestaciones.Add (subestacion);
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }

                return subestaciones;
            } //fin busquedaEstacion

            //Metodo de busqueda de horario por estacion
            string busquedaHorario(string estacion)
            {
                SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ProgramacionCortesDeLuz;Integrated Security=True;");
                using (connection)
                {
                    connection.Open();
                    Console.WriteLine("Buscando en la base de datos...");
                    SqlCommand cmd = new SqlCommand("ObtenerHorariosCorte", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue ("@Estacion", estacion);
                    SqlParameter horariosParam = new SqlParameter("@HorariosCorte", SqlDbType.VarChar, 255)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add (horariosParam);
                    cmd.ExecuteNonQuery();
                    string horarios = (string)horariosParam.Value;
                    connection.Close ();
                    return horarios;
                }
                
            }
            
        }
    }
}
