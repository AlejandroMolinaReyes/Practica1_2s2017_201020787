namespace Cliente
{
    partial class MenuPrincipal
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
            this.dashboard = new System.Windows.Forms.Button();
            this.administrarMensaje = new System.Windows.Forms.Button();
            this.reporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Location = new System.Drawing.Point(110, 32);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(117, 36);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Ver Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // administrarMensaje
            // 
            this.administrarMensaje.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrarMensaje.Location = new System.Drawing.Point(89, 105);
            this.administrarMensaje.Name = "administrarMensaje";
            this.administrarMensaje.Size = new System.Drawing.Size(160, 36);
            this.administrarMensaje.TabIndex = 0;
            this.administrarMensaje.Text = "AdministrarMensaje";
            this.administrarMensaje.UseVisualStyleBackColor = true;
            this.administrarMensaje.Click += new System.EventHandler(this.administrarMensaje_Click);
            // 
            // reporte
            // 
            this.reporte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporte.Location = new System.Drawing.Point(110, 177);
            this.reporte.Name = "reporte";
            this.reporte.Size = new System.Drawing.Size(117, 36);
            this.reporte.TabIndex = 0;
            this.reporte.Text = "Ver Rerpotes";
            this.reporte.UseVisualStyleBackColor = true;
            this.reporte.Click += new System.EventHandler(this.reporte_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 255);
            this.Controls.Add(this.reporte);
            this.Controls.Add(this.administrarMensaje);
            this.Controls.Add(this.dashboard);
            this.MaximumSize = new System.Drawing.Size(353, 293);
            this.MinimumSize = new System.Drawing.Size(353, 293);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipalClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button administrarMensaje;
        private System.Windows.Forms.Button reporte;
    }
}

