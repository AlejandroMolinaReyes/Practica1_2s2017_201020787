namespace Cliente
{
    partial class AdministrarMensajes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonEnviarMensajes = new System.Windows.Forms.Button();
            this.VerCola = new System.Windows.Forms.Button();
            this.verRespuestas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonEnviarMensajes
            // 
            this.ButtonEnviarMensajes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEnviarMensajes.Location = new System.Drawing.Point(78, 32);
            this.ButtonEnviarMensajes.Name = "ButtonEnviarMensajes";
            this.ButtonEnviarMensajes.Size = new System.Drawing.Size(135, 36);
            this.ButtonEnviarMensajes.TabIndex = 0;
            this.ButtonEnviarMensajes.Text = "Enviar mensajes";
            this.ButtonEnviarMensajes.UseVisualStyleBackColor = true;
            this.ButtonEnviarMensajes.Click += new System.EventHandler(this.EnviarMensajes_Click);
            // 
            // VerCola
            // 
            this.VerCola.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerCola.Location = new System.Drawing.Point(61, 105);
            this.VerCola.Name = "VerCola";
            this.VerCola.Size = new System.Drawing.Size(169, 36);
            this.VerCola.TabIndex = 0;
            this.VerCola.Text = "Ver cola de mensajes";
            this.VerCola.UseVisualStyleBackColor = true;
            this.VerCola.Click += new System.EventHandler(this.VerCola_Click);
            // 
            // verRespuestas
            // 
            this.verRespuestas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verRespuestas.Location = new System.Drawing.Point(36, 177);
            this.verRespuestas.Name = "verRespuestas";
            this.verRespuestas.Size = new System.Drawing.Size(212, 36);
            this.verRespuestas.TabIndex = 0;
            this.verRespuestas.Text = "Ver respuestas de mensajes";
            this.verRespuestas.UseVisualStyleBackColor = true;
            this.verRespuestas.Click += new System.EventHandler(this.verRespuestas_Click);
            // 
            // AdministrarMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.verRespuestas);
            this.Controls.Add(this.VerCola);
            this.Controls.Add(this.ButtonEnviarMensajes);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "AdministrarMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministrarMensajes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMensajesClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonEnviarMensajes;
        private System.Windows.Forms.Button VerCola;
        private System.Windows.Forms.Button verRespuestas;
    }
}