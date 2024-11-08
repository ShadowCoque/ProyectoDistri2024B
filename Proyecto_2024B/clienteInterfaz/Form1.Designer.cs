namespace clienteInterfaz
{
    partial class frmCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.flpBarraLateral = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnTengoLuz = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.flpContenido = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.flpBarraLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpBarraLateral
            // 
            this.flpBarraLateral.BackColor = System.Drawing.SystemColors.Highlight;
            this.flpBarraLateral.Controls.Add(this.btnInicio);
            this.flpBarraLateral.Controls.Add(this.btnConsulta);
            this.flpBarraLateral.Controls.Add(this.btnBusqueda);
            this.flpBarraLateral.Controls.Add(this.btnTengoLuz);
            this.flpBarraLateral.Location = new System.Drawing.Point(3, 139);
            this.flpBarraLateral.Margin = new System.Windows.Forms.Padding(4);
            this.flpBarraLateral.Name = "flpBarraLateral";
            this.flpBarraLateral.Size = new System.Drawing.Size(267, 505);
            this.flpBarraLateral.TabIndex = 0;
            this.flpBarraLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.flpBarraLateral_Paint);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicio.Location = new System.Drawing.Point(4, 4);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(253, 65);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsulta.Location = new System.Drawing.Point(4, 77);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(253, 65);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBusqueda.Location = new System.Drawing.Point(4, 150);
            this.btnBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(253, 65);
            this.btnBusqueda.TabIndex = 5;
            this.btnBusqueda.Text = "Búsqueda";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnTengoLuz
            // 
            this.btnTengoLuz.AutoSize = true;
            this.btnTengoLuz.FlatAppearance.BorderSize = 0;
            this.btnTengoLuz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTengoLuz.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTengoLuz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTengoLuz.Location = new System.Drawing.Point(4, 223);
            this.btnTengoLuz.Margin = new System.Windows.Forms.Padding(4);
            this.btnTengoLuz.Name = "btnTengoLuz";
            this.btnTengoLuz.Size = new System.Drawing.Size(253, 74);
            this.btnTengoLuz.TabIndex = 6;
            this.btnTengoLuz.Text = "¿Tengo luz?";
            this.btnTengoLuz.UseVisualStyleBackColor = true;
            this.btnTengoLuz.Click += new System.EventHandler(this.btnTengoLuz_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitulo.Location = new System.Drawing.Point(303, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(835, 69);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "CORTES DE ENERGÍA 2024";
            // 
            // flpContenido
            // 
            this.flpContenido.BackColor = System.Drawing.SystemColors.HighlightText;
            this.flpContenido.BackgroundImage = global::clienteInterfaz.Properties.Resources.cronograma_img;
            this.flpContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpContenido.Location = new System.Drawing.Point(277, 139);
            this.flpContenido.Name = "flpContenido";
            this.flpContenido.Size = new System.Drawing.Size(943, 492);
            this.flpContenido.TabIndex = 5;
            // 
            // flpLogo
            // 
            this.flpLogo.BackColor = System.Drawing.SystemColors.Highlight;
            this.flpLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flpLogo.BackgroundImage")));
            this.flpLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpLogo.Location = new System.Drawing.Point(3, 0);
            this.flpLogo.Margin = new System.Windows.Forms.Padding(4);
            this.flpLogo.Name = "flpLogo";
            this.flpLogo.Size = new System.Drawing.Size(267, 139);
            this.flpLogo.TabIndex = 4;
            this.flpLogo.Click += new System.EventHandler(this.flpLogo_Click);
            this.flpLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.flpLogo_Paint);
            this.flpLogo.MouseEnter += new System.EventHandler(this.flpLogo_MouseEnter);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1232, 634);
            this.Controls.Add(this.flpContenido);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.flpLogo);
            this.Controls.Add(this.flpBarraLateral);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.flpBarraLateral.ResumeLayout(false);
            this.flpBarraLateral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBarraLateral;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.FlowLayoutPanel flpLogo;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnTengoLuz;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.FlowLayoutPanel flpContenido;
    }
}

