namespace Cliente
{
    partial class EnviarMensajes
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
            this.cargarXML = new System.Windows.Forms.Button();
            this.groupMensaje = new System.Windows.Forms.GroupBox();
            this.buttonEnviarMsj = new System.Windows.Forms.Button();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.textMensaje = new System.Windows.Forms.TextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.groupMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // cargarXML
            // 
            this.cargarXML.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargarXML.Location = new System.Drawing.Point(186, 24);
            this.cargarXML.Name = "cargarXML";
            this.cargarXML.Size = new System.Drawing.Size(103, 38);
            this.cargarXML.TabIndex = 0;
            this.cargarXML.Text = "Cargar XML";
            this.cargarXML.UseVisualStyleBackColor = true;
            this.cargarXML.Click += new System.EventHandler(this.cargarXML_Click);
            // 
            // groupMensaje
            // 
            this.groupMensaje.Controls.Add(this.buttonEnviarMsj);
            this.groupMensaje.Controls.Add(this.labelMensaje);
            this.groupMensaje.Controls.Add(this.labelIP);
            this.groupMensaje.Controls.Add(this.textMensaje);
            this.groupMensaje.Controls.Add(this.textIP);
            this.groupMensaje.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMensaje.Location = new System.Drawing.Point(13, 85);
            this.groupMensaje.Name = "groupMensaje";
            this.groupMensaje.Size = new System.Drawing.Size(416, 181);
            this.groupMensaje.TabIndex = 1;
            this.groupMensaje.TabStop = false;
            this.groupMensaje.Text = "Crear un mensaje";
            // 
            // buttonEnviarMsj
            // 
            this.buttonEnviarMsj.Location = new System.Drawing.Point(275, 64);
            this.buttonEnviarMsj.Name = "buttonEnviarMsj";
            this.buttonEnviarMsj.Size = new System.Drawing.Size(125, 37);
            this.buttonEnviarMsj.TabIndex = 2;
            this.buttonEnviarMsj.Text = "Enviar Mensaje";
            this.buttonEnviarMsj.UseVisualStyleBackColor = true;
            this.buttonEnviarMsj.Click += new System.EventHandler(this.buttonEnviarMsj_Click);
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.Location = new System.Drawing.Point(21, 105);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(68, 16);
            this.labelMensaje.TabIndex = 1;
            this.labelMensaje.Text = "Mensaje:";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.Location = new System.Drawing.Point(11, 41);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(89, 16);
            this.labelIP.TabIndex = 1;
            this.labelIP.Text = "Dirrecion IP:";
            // 
            // textMensaje
            // 
            this.textMensaje.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMensaje.Location = new System.Drawing.Point(106, 101);
            this.textMensaje.Name = "textMensaje";
            this.textMensaje.Size = new System.Drawing.Size(148, 23);
            this.textMensaje.TabIndex = 0;
            // 
            // textIP
            // 
            this.textIP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIP.Location = new System.Drawing.Point(106, 37);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(148, 23);
            this.textIP.TabIndex = 0;
            // 
            // EnviarMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 272);
            this.Controls.Add(this.groupMensaje);
            this.Controls.Add(this.cargarXML);
            this.Name = "EnviarMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnviarMensajes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.enviarMensajeClosing);
            this.groupMensaje.ResumeLayout(false);
            this.groupMensaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cargarXML;
        private System.Windows.Forms.GroupBox groupMensaje;
        private System.Windows.Forms.Button buttonEnviarMsj;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textMensaje;
        private System.Windows.Forms.TextBox textIP;
    }
}