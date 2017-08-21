namespace Cliente
{
    partial class Dashboard
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
            this.cargarJSON = new System.Windows.Forms.Button();
            this.tablaNodos = new System.Windows.Forms.DataGridView();
            this.nodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodoLocal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // cargarJSON
            // 
            this.cargarJSON.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargarJSON.Location = new System.Drawing.Point(201, 23);
            this.cargarJSON.Name = "cargarJSON";
            this.cargarJSON.Size = new System.Drawing.Size(99, 34);
            this.cargarJSON.TabIndex = 0;
            this.cargarJSON.Text = "Cargar JSON";
            this.cargarJSON.UseVisualStyleBackColor = true;
            this.cargarJSON.Click += new System.EventHandler(this.cargarJSON_Click);
            // 
            // tablaNodos
            // 
            this.tablaNodos.AllowUserToAddRows = false;
            this.tablaNodos.AllowUserToDeleteRows = false;
            this.tablaNodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaNodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodo,
            this.ip,
            this.carnet,
            this.estado});
            this.tablaNodos.Location = new System.Drawing.Point(12, 77);
            this.tablaNodos.Name = "tablaNodos";
            this.tablaNodos.ReadOnly = true;
            this.tablaNodos.Size = new System.Drawing.Size(443, 300);
            this.tablaNodos.TabIndex = 1;
            // 
            // nodo
            // 
            this.nodo.HeaderText = "Nodo";
            this.nodo.Name = "nodo";
            this.nodo.ReadOnly = true;
            // 
            // ip
            // 
            this.ip.HeaderText = "IP";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            // 
            // carnet
            // 
            this.carnet.HeaderText = "Carnet";
            this.carnet.Name = "carnet";
            this.carnet.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // nodoLocal
            // 
            this.nodoLocal.AutoSize = true;
            this.nodoLocal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodoLocal.Location = new System.Drawing.Point(34, 380);
            this.nodoLocal.Name = "nodoLocal";
            this.nodoLocal.Size = new System.Drawing.Size(81, 16);
            this.nodoLocal.TabIndex = 2;
            this.nodoLocal.Text = "Este Nodo:";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 411);
            this.Controls.Add(this.nodoLocal);
            this.Controls.Add(this.tablaNodos);
            this.Controls.Add(this.cargarJSON);
            this.MaximumSize = new System.Drawing.Size(487, 449);
            this.MinimumSize = new System.Drawing.Size(487, 449);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tablaNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cargarJSON;
        private System.Windows.Forms.DataGridView tablaNodos;
        private System.Windows.Forms.Label nodoLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}