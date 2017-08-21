using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class ColaMensajes : Form
    {
        public ColaMensajes()
        {
            InitializeComponent();
        }

        private void colaMensajesClosing(object sender, FormClosingEventArgs e)
        {
            AdministrarMensajes ventanaAdminMensajes = new AdministrarMensajes();
            ventanaAdminMensajes.Show();
        }

        private void buttonOperar_Click(object sender, EventArgs e)
        {
            string respuesta = Cliente.Connecion.postPeticion("http://127.0.0.1:5000/operar", "");
            if (respuesta.Equals("vacio"))
            {
                numeroCola.Text = "Operaciones en cola: 0";
            } else if(respuesta.Equals("False")) {
                MessageBox.Show("no hay conexion");
            }else if(respuesta.Equals("FalseP"))
            {
                MessageBox.Show("Error de inorden a postorden");
            }else if (respuesta.Equals("FalseO"))
            {
                MessageBox.Show("Error de operacion");
            }
            else
            {
                String[] elementos = respuesta.Split(';');
                String[] datos = elementos[0].Split(',');
                numeroCola.Text = "Operaciones en cola: "+datos[0];
                textCarnet.Text = datos[1];
                textIP.Text = datos[2];
                textResultado.Text = datos[3];
                textInorden.Text = datos[4];
                textPostorden.Text = datos[5];
                String[] consola = elementos[1].Split(',');
                string textoConsola = "";
                foreach (string ejec in consola) {
                    textoConsola = textoConsola + ejec + "\n";
                }
                textConsola.Text = textoConsola;
                respuesta = Cliente.Connecion.postPeticion("http://"+ textIP.Text + ":5000/respuesta", "inorden="+ textInorden.Text+"&postorden="+ textPostorden.Text+"&resultado="+ textResultado.Text);
                if (respuesta.ToLower().Equals("false")){
                    MessageBox.Show("La respuesta no fue entrado: "+textIP.Text);
                }
            }
        }
    }
}
