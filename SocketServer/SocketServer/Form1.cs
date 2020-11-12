using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Threading;

namespace SocketServer
{
    public partial class Form1 : Form
    {
        private bool serving = false;
        private TcpListener server;
        private TcpClient client = new TcpClient();
        private IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, 9090);
        private List<Connection> list = new List<Connection>();
        Connection con;


        private struct Connection
        {
            public NetworkStream stream;
            public StreamWriter streamw;
            public StreamReader streamr;
            public string data;
        }
        
        public Form1()
        {
            InitializeComponent();
        }




        private void encender_Click(object sender, EventArgs e)
        {
            StartServer();
        }




        private void StartServer()
        {
            Thread hilo = new Thread(delegate()
            {
                try
                {
                    server = new TcpListener(ipendpoint);
                    server.Start();
                    serving = true;
                    this.Invoke(new Action(() => { 
                        encender.Enabled = false;
                        apagar.Enabled = true;
                    }));
                    this.Invoke(new Action(() => { mensaje.Text = "Servidor Encendido"; }));
                }
                catch {
                    this.Invoke(new Action(() => { mensaje.Text = "Conflicto en Puerto o IP"; }));
                    this.Invoke(new Action(() =>
                    {
                        encender.Enabled = true;
                        apagar.Enabled = false;
                    }));
                }

                



                while (serving)
                {
                    try
                    {
                        client = server.AcceptTcpClient();

                        con = new Connection();
                        con.stream = client.GetStream();
                        con.streamr = new StreamReader(con.stream);
                        con.streamw = new StreamWriter(con.stream);

                        con.data = con.streamr.ReadLine();
                        list.Add(con);
                        string cliente, servidor;
                        cliente = "CLIENTE: " + con.data;
                        servidor = "RESPUESTA AUTOMATICA";
                        this.Invoke(new Action(() => { mensaje.Text = mensaje.Text + Environment.NewLine + cliente; }));
                        this.Invoke(new Action(() => { mensaje.Text = mensaje.Text + Environment.NewLine + "SERVER: " + servidor + Environment.NewLine; }));

                        con.streamw.WriteLine(servidor);
                        con.streamw.Flush();
                        con.stream.Close();
                        list.Remove(con);
                    }
                    catch {
                        client.Close();
                    }
                }
            });
            hilo.Start();
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            serving = false;
            server.Stop();
            mensaje.Text = "Servidor Apagado";
            encender.Enabled = true;
            apagar.Enabled = false;
        }



        
            
            



    }
}
