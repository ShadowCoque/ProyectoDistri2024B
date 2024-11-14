using clienteInterfaz.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clienteInterfaz
{
    public partial class frmCliente : Form
    {
        private IPEndPoint remoto = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000);
        private TcpClient cliente = new TcpClient();

        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            flpContenido.BringToFront();
            lblInfoLuz.Text = "";
            dGVEStaciones.Visible = false;
            lblHorario.Text = "";
            lblInd.Text = "";

        }

        private void flpLogo_Paint(object sender, PaintEventArgs e)
        {
            // Color y grosor del borde
            Color borderColor = Color.White; // Cambia al color que prefieras
            int borderWidth = 2; // Grosor de la línea del borde

            // Crear un objeto Pen con el color y grosor
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                // Dibujar la línea en la parte inferior
                e.Graphics.DrawLine(pen, 0, flpLogo.Height - 1, flpLogo.Width, flpLogo.Height - 1);

                // Dibujar la línea en el borde derecho
                e.Graphics.DrawLine(pen, flpLogo.Width - 1, 0, flpLogo.Width - 1, flpLogo.Height);
            }
        }

        private void flpBarraLateral_Paint(object sender, PaintEventArgs e)
        {
            // Color y grosor del borde
            Color borderColor = Color.White; // Cambia al color que prefieras
            int borderWidth = 2; // Grosor de la línea del borde derecho

            // Crear un objeto Pen con el color y grosor
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                // Dibujar la línea en el borde derecho
                e.Graphics.DrawLine(pen, flpBarraLateral.Width - 1, 0, flpBarraLateral.Width - 1, flpBarraLateral.Height);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            flpContenido.BringToFront();
        }

        private void flpLogo_Click(object sender, EventArgs e)
        {
            flpContenido.BringToFront();

        }

        private void flpLogo_MouseEnter(object sender, EventArgs e)
        {
            flpLogo.Cursor = Cursors.Hand;
        }
        private void flpLogo_MouseLeave(object sender, EventArgs e)
        {
            flpLogo.Cursor = Cursors.Default;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            pnlBusqueda.SendToBack();
            pnlTengoLuz.SendToBack();
            pnlConsulta.BringToFront();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            pnlBusqueda.BringToFront();
        }

        private void btnTengoLuz_Click(object sender, EventArgs e)
        {
            pnlBusqueda.SendToBack();
            pnlBusqueda.SendToBack();
            pnlTengoLuz.BringToFront();
        }

        //Para busqueda de horario por estacion
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!cliente.Connected)
            {
                cliente.Connect(remoto);
            }
            if (cliente.Connected)
            {
                // Lo que va a enviar el cliente
                NetworkStream flujo = cliente.GetStream();
                byte[] bufferTx = Encoding.ASCII.GetBytes("busquedaHorario" + "|" + txtEstacionConsulta.Text.ToString());
                flujo.Write(bufferTx, 0, bufferTx.Length);

                // Lo que va a recibir el cliente
                byte[] bufferRx = new byte[1024];
                int bytesLeidos = await flujo.ReadAsync(bufferRx, 0, bufferRx.Length);
                if (bytesLeidos > 0)
                {
                    string respuesta = Encoding.ASCII.GetString(bufferRx, 0, bytesLeidos);
                    lblInd.Text = "Horario de desconexión:";
                    lblHorario.Text = respuesta;
                }

                
            }
        }

        private async void btnParametro_Click(object sender, EventArgs e)
        {
            if (!cliente.Connected)
            {
                cliente.Connect(remoto);
            }
            if (cliente.Connected)
            {
                NetworkStream flujo = cliente.GetStream();
                byte[] bufferTx = Encoding.ASCII.GetBytes("busquedaEstacion" + "|" + txtParametro.Text.ToString());
                flujo.Write(bufferTx, 0, bufferTx.Length);

                byte[] bufferRx = new byte[1024];
                int bytesLeidos = await flujo.ReadAsync(bufferRx, 0, bufferRx.Length);
                if (bytesLeidos>0)
                {
                    string respuesta = Encoding.ASCII.GetString(bufferRx, 0, bufferRx.Length);
                    string[] respuestas = respuesta.Split('|');
                    dGVEStaciones.Rows.Clear();
                    foreach(string estacion in respuestas)
                    {
                        dGVEStaciones.Rows.Add("- " + estacion);
                    }
                }
            }
            dGVEStaciones.Visible = true;
        }

        private async void btnLuz_Click(object sender, EventArgs e)
        {
            DateTime ahora = DateTime.Now;
            TimeSpan horaLocal = ahora.TimeOfDay;
            if (!cliente.Connected)
            {
                cliente.Connect(remoto);
            }
            if (cliente.Connected)
            {
                NetworkStream flujo = cliente.GetStream();
                byte[] bufferTx = Encoding.ASCII.GetBytes("tengoLuz" + "|" + horaLocal.ToString()/*"05:30:15"*/ + "|" + txtTengoLuz.Text.ToString());
                flujo.Write(bufferTx, 0, bufferTx.Length);

                byte[] bufferRx = new byte[1024];
                int bytesLeidos = await flujo.ReadAsync(bufferRx, 0, bufferRx.Length);
                if (bytesLeidos > 0)
                {
                    string respuesta = Encoding.ASCII.GetString(bufferRx, 0, bytesLeidos);
                    lblInfoLuz.Text = respuesta; // Mostrar respuesta en la interfaz
                }

            }
            //cliente.Close();
        }

        private void frmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            cliente.Close();
        }

        /*private async Task EscucharRespuesta()
        {
            try
            {
                NetworkStream flujo;
                byte[] bufferRx = new byte[512];
                int bytesLeidos = await flujo.ReadAsync(bufferRx, 0, bufferRx.Length);
                if (bytesLeidos > 0)
                {
                    string respuesta = Encoding.ASCII.GetString(bufferRx, 0, bytesLeidos);
                    txtRespuesta.Text = respuesta; // Mostrar respuesta en la interfaz
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recibir respuesta: {ex.Message}");
            }
        }*/

    }
}
