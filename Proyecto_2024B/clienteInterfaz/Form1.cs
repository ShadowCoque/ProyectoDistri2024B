using clienteInterfaz.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clienteInterfaz
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            flpContenido.BringToFront();
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
    }
}
