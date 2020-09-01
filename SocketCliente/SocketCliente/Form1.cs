using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketCliente
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private static NetworkStream stream;
        private static StreamWriter streamw;
        private static StreamReader streamr;
        



        public Form1()
        {
            InitializeComponent();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient client = new TcpClient(ip.Text, Convert.ToInt32(puerto.Text));
                

                stream = client.GetStream();
                stream.ReadTimeout = 2000;
                streamw = new StreamWriter(stream);
                streamr = new StreamReader(stream);
                streamw.WriteLine(textocliente.Text);
                streamw.Flush();

                string cliente, servidor;
                cliente = Environment.NewLine+"CLIENTE: "+textocliente.Text;
                servidor = Environment.NewLine + "SERVIDOR: " + streamr.ReadLine() + Environment.NewLine;
                mensaje.Text = mensaje.Text + cliente + servidor;
                
                /*string data = streamr.ReadLine();
                while (data != null) {
                    MessageBox.Show(data);
                    data = streamr.ReadLine();
                }*/
                   
                stream.Close();
                client.Close();
                    
                
                
            }
            catch{
                mensaje.Text = "Conflicto en Puerto o IP";
            }
        }






    }
}
