namespace clienteInterfaz
{
    partial class flpTitulo
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
            this.flpBarraLateral = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnTengoLuz = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.flpBarraLateral.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpBarraLateral
            // 
            this.flpBarraLateral.BackColor = System.Drawing.SystemColors.Highlight;
            this.flpBarraLateral.Controls.Add(this.btnInicio);
            this.flpBarraLateral.Controls.Add(this.btnConsulta);
            this.flpBarraLateral.Controls.Add(this.btnBusqueda);
            this.flpBarraLateral.Controls.Add(this.btnTengoLuz);
            this.flpBarraLateral.Location = new System.Drawing.Point(2, 113);
            this.flpBarraLateral.Name = "flpBarraLateral";
            this.flpBarraLateral.Size = new System.Drawing.Size(200, 410);
            this.flpBarraLateral.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.txtTitulo);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(208, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(646, 65);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicio.Location = new System.Drawing.Point(3, 3);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(190, 53);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(2, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 113);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // btnConsulta
            // 
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsulta.Location = new System.Drawing.Point(3, 62);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(190, 53);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBusqueda.Location = new System.Drawing.Point(3, 121);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(190, 53);
            this.btnBusqueda.TabIndex = 5;
            this.btnBusqueda.Text = "Búsqueda";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // btnTengoLuz
            // 
            this.btnTengoLuz.AutoSize = true;
            this.btnTengoLuz.FlatAppearance.BorderSize = 0;
            this.btnTengoLuz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTengoLuz.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTengoLuz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTengoLuz.Location = new System.Drawing.Point(3, 180);
            this.btnTengoLuz.Name = "btnTengoLuz";
            this.btnTengoLuz.Size = new System.Drawing.Size(190, 60);
            this.btnTengoLuz.TabIndex = 6;
            this.btnTengoLuz.Text = "¿Tengo luz?";
            this.btnTengoLuz.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTitulo.Location = new System.Drawing.Point(3, 3);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(413, 50);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "CORTES DE ENERGÍA 2024";
            // 
            // flpTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(854, 515);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flpBarraLateral);
            this.Name = "flpTitulo";
            this.Text = "Form1";
            this.flpBarraLateral.ResumeLayout(false);
            this.flpBarraLateral.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBarraLateral;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnTengoLuz;
        private System.Windows.Forms.TextBox txtTitulo;
    }
}

