using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Cliente
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Dashboard ventanaDashboard = new Dashboard();
            ventanaDashboard.Show();
            this.Dispose();

        }

        private void MenuPrincipalClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void administrarMensaje_Click(object sender, EventArgs e)
        {
            AdministrarMensajes ventanaAdminMsj = new AdministrarMensajes();
            ventanaAdminMsj.Show();
            this.Dispose();
        }

        private void reporte_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "img\\cola.txt");
            string pathImagen = Path.Combine(Application.StartupPath, "img\\cola.jpg");
            string respuesta = Cliente.Connecion.postPeticion("http://127.0.0.1:5000/graficarCola", "");
            if (!respuesta.Equals("False")){
                File.WriteAllText(path,respuesta);
                Cmd.ExecuteCommand("dot -Tjpg " + path + " -o " + pathImagen);
                Process.Start(pathImagen);
            }
            else
            {
                MessageBox.Show("Creacion de la imagen fallida");
            }
            
            
        }
    }
}
