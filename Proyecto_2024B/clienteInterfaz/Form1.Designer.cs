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
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlConsulta = new System.Windows.Forms.Panel();
            this.lblParametro = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.btnParametro = new System.Windows.Forms.Button();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.pnlTengoLuz = new System.Windows.Forms.Panel();
            this.txtTengoLuz = new System.Windows.Forms.TextBox();
            this.lblTengoLuz = new System.Windows.Forms.Label();
            this.btnLuz = new System.Windows.Forms.Button();
            this.flpBarraLateral.SuspendLayout();
            this.pnlConsulta.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.pnlTengoLuz.SuspendLayout();
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
            this.flpContenido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flpContenido.BackgroundImage")));
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
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIndicacion.Location = new System.Drawing.Point(53, 37);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(278, 32);
            this.lblIndicacion.TabIndex = 1;
            this.lblIndicacion.Text = "Ingrese su estación";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Honeydew;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(59, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(828, 27);
            this.textBox1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(394, 140);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 47);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.BackColor = System.Drawing.Color.White;
            this.pnlConsulta.Controls.Add(this.textBox1);
            this.pnlConsulta.Controls.Add(this.lblIndicacion);
            this.pnlConsulta.Controls.Add(this.btnBuscar);
            this.pnlConsulta.Location = new System.Drawing.Point(277, 139);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(943, 492);
            this.pnlConsulta.TabIndex = 0;
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblParametro.Location = new System.Drawing.Point(53, 41);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(716, 32);
            this.lblParametro.TabIndex = 1;
            this.lblParametro.Text = "Ingrese un parámetro válido para buscar estaciones";
            // 
            // txtParametro
            // 
            this.txtParametro.BackColor = System.Drawing.Color.Honeydew;
            this.txtParametro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.Location = new System.Drawing.Point(59, 90);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(828, 27);
            this.txtParametro.TabIndex = 2;
            // 
            // btnParametro
            // 
            this.btnParametro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametro.ForeColor = System.Drawing.Color.White;
            this.btnParametro.Location = new System.Drawing.Point(394, 144);
            this.btnParametro.Name = "btnParametro";
            this.btnParametro.Size = new System.Drawing.Size(144, 47);
            this.btnParametro.TabIndex = 3;
            this.btnParametro.Text = "Buscar";
            this.btnParametro.UseVisualStyleBackColor = false;
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.Color.White;
            this.pnlBusqueda.Controls.Add(this.btnParametro);
            this.pnlBusqueda.Controls.Add(this.txtParametro);
            this.pnlBusqueda.Controls.Add(this.lblParametro);
            this.pnlBusqueda.Location = new System.Drawing.Point(277, 136);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(943, 492);
            this.pnlBusqueda.TabIndex = 4;
            // 
            // pnlTengoLuz
            // 
            this.pnlTengoLuz.BackColor = System.Drawing.Color.White;
            this.pnlTengoLuz.Controls.Add(this.txtTengoLuz);
            this.pnlTengoLuz.Controls.Add(this.lblTengoLuz);
            this.pnlTengoLuz.Controls.Add(this.btnLuz);
            this.pnlTengoLuz.Location = new System.Drawing.Point(277, 152);
            this.pnlTengoLuz.Name = "pnlTengoLuz";
            this.pnlTengoLuz.Size = new System.Drawing.Size(943, 492);
            this.pnlTengoLuz.TabIndex = 4;
            // 
            // txtTengoLuz
            // 
            this.txtTengoLuz.BackColor = System.Drawing.Color.Honeydew;
            this.txtTengoLuz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTengoLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTengoLuz.Location = new System.Drawing.Point(59, 72);
            this.txtTengoLuz.Name = "txtTengoLuz";
            this.txtTengoLuz.Size = new System.Drawing.Size(828, 27);
            this.txtTengoLuz.TabIndex = 2;
            // 
            // lblTengoLuz
            // 
            this.lblTengoLuz.AutoSize = true;
            this.lblTengoLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTengoLuz.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTengoLuz.Location = new System.Drawing.Point(53, 23);
            this.lblTengoLuz.Name = "lblTengoLuz";
            this.lblTengoLuz.Size = new System.Drawing.Size(278, 32);
            this.lblTengoLuz.TabIndex = 1;
            this.lblTengoLuz.Text = "Ingrese su estación";
            // 
            // btnLuz
            // 
            this.btnLuz.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuz.ForeColor = System.Drawing.Color.White;
            this.btnLuz.Location = new System.Drawing.Point(364, 126);
            this.btnLuz.Name = "btnLuz";
            this.btnLuz.Size = new System.Drawing.Size(193, 76);
            this.btnLuz.TabIndex = 3;
            this.btnLuz.Text = "¿Tengo luz?";
            this.btnLuz.UseVisualStyleBackColor = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1229, 634);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.flpLogo);
            this.Controls.Add(this.flpBarraLateral);
            this.Controls.Add(this.flpContenido);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlConsulta);
            this.Controls.Add(this.pnlTengoLuz);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.flpBarraLateral.ResumeLayout(false);
            this.flpBarraLateral.PerformLayout();
            this.pnlConsulta.ResumeLayout(false);
            this.pnlConsulta.PerformLayout();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlTengoLuz.ResumeLayout(false);
            this.pnlTengoLuz.PerformLayout();
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
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlConsulta;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Button btnParametro;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Panel pnlTengoLuz;
        private System.Windows.Forms.TextBox txtTengoLuz;
        private System.Windows.Forms.Label lblTengoLuz;
        private System.Windows.Forms.Button btnLuz;
    }
}

