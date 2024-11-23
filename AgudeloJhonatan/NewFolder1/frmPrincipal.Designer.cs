namespace AgudeloJhonatan
{
    partial class frmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdReportes = new System.Windows.Forms.Button();
            this.cmdActividades = new System.Windows.Forms.Button();
            this.cmdUsuarios = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.cmdReportes);
            this.panel1.Controls.Add(this.cmdActividades);
            this.panel1.Controls.Add(this.cmdUsuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 448);
            this.panel1.TabIndex = 0;
            // 
            // cmdReportes
            // 
            this.cmdReportes.Location = new System.Drawing.Point(12, 293);
            this.cmdReportes.Name = "cmdReportes";
            this.cmdReportes.Size = new System.Drawing.Size(120, 41);
            this.cmdReportes.TabIndex = 2;
            this.cmdReportes.Text = "Reportes";
            this.cmdReportes.UseVisualStyleBackColor = true;
            // 
            // cmdActividades
            // 
            this.cmdActividades.Location = new System.Drawing.Point(12, 205);
            this.cmdActividades.Name = "cmdActividades";
            this.cmdActividades.Size = new System.Drawing.Size(120, 41);
            this.cmdActividades.TabIndex = 1;
            this.cmdActividades.Text = "Actividades";
            this.cmdActividades.UseVisualStyleBackColor = true;
            // 
            // cmdUsuarios
            // 
            this.cmdUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdUsuarios.Location = new System.Drawing.Point(12, 118);
            this.cmdUsuarios.Name = "cmdUsuarios";
            this.cmdUsuarios.Size = new System.Drawing.Size(120, 41);
            this.cmdUsuarios.TabIndex = 0;
            this.cmdUsuarios.Text = "Usuarios";
            this.cmdUsuarios.UseVisualStyleBackColor = false;
            this.cmdUsuarios.Click += new System.EventHandler(this.cmdUsuarios_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(145, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 57);
            this.panel2.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(156, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PAGINA PRINCIPAL";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(635, 448);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdReportes;
        private System.Windows.Forms.Button cmdActividades;
        private System.Windows.Forms.Button cmdUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
    }
}

