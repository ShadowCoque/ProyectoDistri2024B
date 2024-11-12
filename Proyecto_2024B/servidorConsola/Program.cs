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
                int bytesLeidos = await flujo.ReadAsync(bufferRx, 0, bufferRx.Length);
                do
                {
                    string solicitud = Encoding.ASCII.GetString(bufferRx, 0, bytesLeidos);
                    Console.WriteLine("Solicitud recibida");
                    
                    //Para separar metodo y parametros
                    string[] partes = solicitud.Split('|');
                    string metodo = partes[0];
                    if(metodo)
                    for (int i = 0; i == partes.Length; i++)
                    {

                    }
                }while (bytesLeidos > 0);
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
                        SqlParameter tieneLuzParam = new SqlParameter("@TieneLuz", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output,
                        };
                        //Se pasa el parámetro tieneLuz al proc. almacenado
                        cmd.Parameters.Add(tieneLuzParam);
                        //Se ejecuta el procedimiento
                        cmd.ExecuteNonQuery();
                        //Se obtiene el valor del parámetro de salida
                        bool tieneLuz = (bool)tieneLuzParam.Value;
                        connection.Close();
                        if(tieneLuz)
                        {
                            return "Si tienes luz";
                        }
                        else
                        {
                            return "No tienes luz";
                        }
                    }
                    catch (Exception ex) { 
                        Console.WriteLine(ex.Message);
                        return "No se pudo encontrar ninguna información relacionada a la estación ingresada";
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
            
        }
    }
}
