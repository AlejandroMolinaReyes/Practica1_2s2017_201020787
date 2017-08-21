namespace Cliente
{
    partial class RepuestaMensajes
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
            this.tablaRespuesta = new System.Windows.Forms.DataGridView();
            this.carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postorden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAntiguos = new System.Windows.Forms.Button();
            this.buttonRecientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRespuesta)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaRespuesta
            // 
            this.tablaRespuesta.AllowUserToAddRows = false;
            this.tablaRespuesta.AllowUserToDeleteRows = false;
            this.tablaRespuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRespuesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carnet,
            this.ip,
            this.inorden,
            this.postorden,
            this.resultado});
            this.tablaRespuesta.Location = new System.Drawing.Point(12, 24);
            this.tablaRespuesta.Name = "tablaRespuesta";
            this.tablaRespuesta.ReadOnly = true;
            this.tablaRespuesta.Size = new System.Drawing.Size(784, 407);
            this.tablaRespuesta.TabIndex = 0;
            // 
            // carnet
            // 
            this.carnet.HeaderText = "Carnet que opero";
            this.carnet.MinimumWidth = 10;
            this.carnet.Name = "carnet";
            this.carnet.ReadOnly = true;
            this.carnet.Width = 120;
            // 
            // ip
            // 
            this.ip.HeaderText = "IP que opero";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            this.ip.Width = 120;
            // 
            // inorden
            // 
            this.inorden.HeaderText = "Inorden";
            this.inorden.Name = "inorden";
            this.inorden.ReadOnly = true;
            this.inorden.Width = 200;
            // 
            // postorden
            // 
            this.postorden.HeaderText = "Postorden";
            this.postorden.Name = "postorden";
            this.postorden.ReadOnly = true;
            this.postorden.Width = 200;
            // 
            // resultado
            // 
            this.resultado.HeaderText = "Resultado";
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            // 
            // buttonAntiguos
            // 
            this.buttonAntiguos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAntiguos.Location = new System.Drawing.Point(12, 452);
            this.buttonAntiguos.Name = "buttonAntiguos";
            this.buttonAntiguos.Size = new System.Drawing.Size(384, 36);
            this.buttonAntiguos.TabIndex = 1;
            this.buttonAntiguos.Text = "Mostrar empezando por los mas antiguos";
            this.buttonAntiguos.UseVisualStyleBackColor = true;
            this.buttonAntiguos.Click += new System.EventHandler(this.buttonAntiguos_Click);
            // 
            // buttonRecientes
            // 
            this.buttonRecientes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecientes.Location = new System.Drawing.Point(413, 452);
            this.buttonRecientes.Name = "buttonRecientes";
            this.buttonRecientes.Size = new System.Drawing.Size(384, 36);
            this.buttonRecientes.TabIndex = 1;
            this.buttonRecientes.Text = "Mostrar empezando por los mas recientes";
            this.buttonRecientes.UseVisualStyleBackColor = true;
            this.buttonRecientes.Click += new System.EventHandler(this.buttonRecientes_Click);
            // 
            // RepuestaMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 500);
            this.Controls.Add(this.buttonRecientes);
            this.Controls.Add(this.buttonAntiguos);
            this.Controls.Add(this.tablaRespuesta);
            this.Name = "RepuestaMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Respuesta de los  mensajes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.repuestaMensajesClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tablaRespuesta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaRespuesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn inorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn postorden;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultado;
        private System.Windows.Forms.Button buttonAntiguos;
        private System.Windows.Forms.Button buttonRecientes;
    }
}