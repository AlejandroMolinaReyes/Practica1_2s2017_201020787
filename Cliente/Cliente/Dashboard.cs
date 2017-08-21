using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Management;
using System.Management.Instrumentation;


namespace Cliente
{
    public partial class Dashboard : Form
    {
        Thread hilo;
        delegate void actualizar(string carnet,string ip,string mascara);
        delegate void limpiar();

        public Dashboard()
        {
            InitializeComponent();
            this.hilo = new Thread(new ThreadStart(this.estadoNodos));
            this.hilo.Start();
             
        }

        private void cargarJSON_Click(object sender, EventArgs e)
        {
            string path = "";
            string respuesta = "";
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.Filter = "Archivo JSON|*.json";
            if (abrirArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = abrirArchivo.FileName;
                respuesta = Cliente.Connecion.postPeticion("http://127.0.0.1:5000/cargaJSON", "path=" + path);
                if (respuesta.Equals("False")){
                    MessageBox.Show("Operacion Fallida");
                }
                else {
                    this.configIP();
                }
            }
            
        }

        private void DashboardClosing(object sender, FormClosingEventArgs e)
        {
            this.hilo.Abort();
            MenuPrincipal ventanaMenuPrincipal = new MenuPrincipal();
            ventanaMenuPrincipal.Show();
        }

        private void estadoNodos()
        {
            while (true)
            {
                
                string nodos = Cliente.Connecion.postPeticion("http://127.0.0.1:5000/dashboard", "");
                string[] nodo = nodos.Split(';');
                foreach (string datos in nodo) {
                    if (!datos.Equals(""))
                    {
                        
                        string[] dato = datos.Split(',');
                        if (!dato[0].Equals("False"))
                        {
                            actualizar act = new actualizar(cambiarEstado);
                            this.Invoke(act, dato);
                        }
                        
                    }
                    
                }
                Thread.Sleep(20000);
                limpiar limp = new limpiar(limpiarTabla);
                this.Invoke(limp);
            }

        }

        private void cambiarEstado(string carnet, string ip, string mascara)
        {
            if (carnet.Equals("201020787")) {
                this.nodoLocal.Text = "Este Nodo: " + ip + " - 201020787";
            }
            string estado = "Desconectado";
            string respuesta = Cliente.Connecion.getPeticion("http://" + ip+":5000/conectado");
            if (!respuesta.Equals("False")) {
               string res =  Cliente.Connecion.postPeticion("http://127.0.0.1:5000/updateCarnet", "ip="+ip+"&carnet="+respuesta);
                estado = "Activo";
            } 
            this.tablaNodos.Rows.Add(carnet, ip, mascara, estado);
        }

        private void limpiarTabla() {
            this.tablaNodos.Rows.Clear();
        }

        private void configIP() {

            string config= Cliente.Connecion.postPeticion("http://127.0.0.1:5000/ip", "carnet=201020787");
            if (!config.Equals("False"))
            {
                string[] ipMascara = config.Split(',');
                this.nodoLocal.Text = "Este Nodo: " + ipMascara[0] + " - 201020787";
                string ipLocal = ipMascara[0];
                string mascaraLocal = ipMascara[1];
                string ipMaquina = "netsh interface ipv4 set address name=\"Conexión de red inalámbrica\" source=static address="+ipLocal+" mask="+mascaraLocal+" gateway=192.168.1.1";
                string dns1 = "netsh interface ipv4 add dnsserver name=\"Conexión de red inalámbrica\" address=216.230.0.3 index=1";
                string dns2 = "netsh interface ipv4 add dnsserver name=\"Conexión de red inalámbrica\" address=8.8.8.8 index=2";
                string respuesta = Cliente.Cmd.ExecuteCommand(ipMaquina);
                if (!respuesta.Equals("False"))
                {
                    Cliente.Cmd.ExecuteCommand(dns1);
                    Cliente.Cmd.ExecuteCommand(dns2);
                    MessageBox.Show("Operacion Exitosa");
                }
                else
                {
                    MessageBox.Show("Configuracion de la ip Fallida,carga JSON exitosa");
                }


            }
            else {

                MessageBox.Show("Configuracion de la ip Fallida,carga JSON exitosa");
            }
        }


    }
}
