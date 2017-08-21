namespace Cliente
{
    partial class ColaMensajes
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
            this.numeroCola = new System.Windows.Forms.Label();
            this.labelCarnet = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelRepuesta = new System.Windows.Forms.Label();
            this.labelInorden = new System.Windows.Forms.Label();
            this.labelPosorden = new System.Windows.Forms.Label();
            this.textCarnet = new System.Windows.Forms.TextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.textInorden = new System.Windows.Forms.TextBox();
            this.textPostorden = new System.Windows.Forms.TextBox();
            this.labelConsola = new System.Windows.Forms.Label();
            this.buttonOperar = new System.Windows.Forms.Button();
            this.textConsola = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // numeroCola
            // 
            this.numeroCola.AutoSize = true;
            this.numeroCola.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroCola.Location = new System.Drawing.Point(241, 33);
            this.numeroCola.Name = "numeroCola";
            this.numeroCola.Size = new System.Drawing.Size(187, 18);
            this.numeroCola.TabIndex = 0;
            this.numeroCola.Text = "Operaciones en cola: ";
            // 
            // labelCarnet
            // 
            this.labelCarnet.AutoSize = true;
            this.labelCarnet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarnet.Location = new System.Drawing.Point(45, 119);
            this.labelCarnet.Name = "labelCarnet";
            this.labelCarnet.Size = new System.Drawing.Size(235, 18);
            this.labelCarnet.TabIndex = 0;
            this.labelCarnet.Text = "Carnet que hizo el mensaje";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.Location = new System.Drawing.Point(62, 191);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(198, 18);
            this.labelIP.TabIndex = 0;
            this.labelIP.Text = "IP que hizo el mensaje";
            // 
            // labelRepuesta
            // 
            this.labelRepuesta.AutoSize = true;
            this.labelRepuesta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepuesta.Location = new System.Drawing.Point(58, 281);
            this.labelRepuesta.Name = "labelRepuesta";
            this.labelRepuesta.Size = new System.Drawing.Size(222, 18);
            this.labelRepuesta.TabIndex = 0;
            this.labelRepuesta.Text = "Resultado de la operacion";
            // 
            // labelInorden
            // 
            this.labelInorden.AutoSize = true;
            this.labelInorden.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInorden.Location = new System.Drawing.Point(77, 364);
            this.labelInorden.Name = "labelInorden";
            this.labelInorden.Size = new System.Drawing.Size(183, 18);
            this.labelInorden.TabIndex = 0;
            this.labelInorden.Text = "Operacion en inorden";
            // 
            // labelPosorden
            // 
            this.labelPosorden.AutoSize = true;
            this.labelPosorden.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosorden.Location = new System.Drawing.Point(76, 448);
            this.labelPosorden.Name = "labelPosorden";
            this.labelPosorden.Size = new System.Drawing.Size(204, 18);
            this.labelPosorden.TabIndex = 0;
            this.labelPosorden.Text = "Operacion en postorden";
            // 
            // textCarnet
            // 
            this.textCarnet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCarnet.Location = new System.Drawing.Point(82, 154);
            this.textCarnet.Name = "textCarnet";
            this.textCarnet.ReadOnly = true;
            this.textCarnet.Size = new System.Drawing.Size(159, 23);
            this.textCarnet.TabIndex = 1;
            // 
            // textIP
            // 
            this.textIP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIP.Location = new System.Drawing.Point(82, 236);
            this.textIP.Name = "textIP";
            this.textIP.ReadOnly = true;
            this.textIP.Size = new System.Drawing.Size(159, 23);
            this.textIP.TabIndex = 1;
            // 
            // textResultado
            // 
            this.textResultado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.Location = new System.Drawing.Point(82, 323);
            this.textResultado.Name = "textResultado";
            this.textResultado.ReadOnly = true;
            this.textResultado.Size = new System.Drawing.Size(159, 23);
            this.textResultado.TabIndex = 1;
            // 
            // textInorden
            // 
            this.textInorden.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInorden.Location = new System.Drawing.Point(48, 398);
            this.textInorden.Name = "textInorden";
            this.textInorden.ReadOnly = true;
            this.textInorden.Size = new System.Drawing.Size(232, 23);
            this.textInorden.TabIndex = 1;
            // 
            // textPostorden
            // 
            this.textPostorden.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPostorden.Location = new System.Drawing.Point(48, 487);
            this.textPostorden.Name = "textPostorden";
            this.textPostorden.ReadOnly = true;
            this.textPostorden.Size = new System.Drawing.Size(232, 23);
            this.textPostorden.TabIndex = 1;
            // 
            // labelConsola
            // 
            this.labelConsola.AutoSize = true;
            this.labelConsola.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConsola.Location = new System.Drawing.Point(315, 119);
            this.labelConsola.Name = "labelConsola";
            this.labelConsola.Size = new System.Drawing.Size(182, 18);
            this.labelConsola.TabIndex = 0;
            this.labelConsola.Text = "Consola de Ejecucion";
            // 
            // buttonOperar
            // 
            this.buttonOperar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperar.Location = new System.Drawing.Point(552, 70);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(112, 32);
            this.buttonOperar.TabIndex = 3;
            this.buttonOperar.Text = "Operar";
            this.buttonOperar.UseVisualStyleBackColor = true;
            this.buttonOperar.Click += new System.EventHandler(this.buttonOperar_Click);
            // 
            // textConsola
            // 
            this.textConsola.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConsola.Location = new System.Drawing.Point(318, 154);
            this.textConsola.Name = "textConsola";
            this.textConsola.ReadOnly = true;
            this.textConsola.Size = new System.Drawing.Size(394, 375);
            this.textConsola.TabIndex = 4;
            this.textConsola.Text = "";
            // 
            // ColaMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 541);
            this.Controls.Add(this.textConsola);
            this.Controls.Add(this.buttonOperar);
            this.Controls.Add(this.textPostorden);
            this.Controls.Add(this.textInorden);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.textCarnet);
            this.Controls.Add(this.labelPosorden);
            this.Controls.Add(this.labelInorden);
            this.Controls.Add(this.labelRepuesta);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.labelConsola);
            this.Controls.Add(this.labelCarnet);
            this.Controls.Add(this.numeroCola);
            this.Name = "ColaMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cola de mensajes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.colaMensajesClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numeroCola;
        private System.Windows.Forms.Label labelCarnet;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelRepuesta;
        private System.Windows.Forms.Label labelInorden;
        private System.Windows.Forms.Label labelPosorden;
        private System.Windows.Forms.TextBox textCarnet;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.TextBox textInorden;
        private System.Windows.Forms.TextBox textPostorden;
        private System.Windows.Forms.Label labelConsola;
        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.RichTextBox textConsola;
    }
}