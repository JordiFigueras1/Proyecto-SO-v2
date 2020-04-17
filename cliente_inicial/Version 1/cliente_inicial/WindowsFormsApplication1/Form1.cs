using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }
        bool conectado = false;
        private void atender_mensajes_servidor()
        {
            while (true)
            {
                byte[] msg = new byte[80];

                // recibo mensaje del servidor
                if (conectado == false)
                {
                    server.Shutdown(SocketShutdown.Both);
                    server.Close();
                    break;
                }

                else
                {
                    server.Receive(msg);

                    string mensaje = Encoding.ASCII.GetString(msg);
                    mensaje = mensaje.TrimEnd('\0');  //Limpia el mensaje del servidor
                    string[] trozos = mensaje.Split('/');

                    // Averiguo el tipo de mensaje

                    if (trozos[0] == "1")
                    {
                        MessageBox.Show("Registro ok");
                    }
                    if (trozos[0] == "-1")
                    {
                        MessageBox.Show("Registro fallido");
                    }
                    if (trozos[0] == "2")
                    {
                        MessageBox.Show("Login ok");

                    }
                    if (trozos[0] == "-2")
                    {
                        MessageBox.Show("Login fallido");
                    }
                    if (trozos[0] == "3")
                    {
                        MessageBox.Show("el jugador ha ganado:" + trozos[1] + "partidas");
                    }
                    if (trozos[0] == "-3")
                    {
                        MessageBox.Show("Peticion fallida");
                    }

                    if (trozos[0] == "5")
                    {
                        MessageBox.Show("hay:" + trozos[1] + "jugadores registrados");
                    }
                    if (trozos[0] == "-5")
                    {
                        MessageBox.Show("Peticion fallida");
                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

   
        private void button2_Click(object sender, EventArgs e)
        {    

                if (Longitud.Checked)
                {
                    // Quiere saber la longitud
                    string mensaje = "3/" + nombre.Text;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("La longitud de tu nombre es: " + mensaje);
                }
                else
                {
                    // Quiere saber si el nombre es bonito
                    string mensaje = "4/" + nombre.Text;
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];


                    if (mensaje == "SI")
                        MessageBox.Show("Tu nombre ES bonito.");
                    else
                        MessageBox.Show("Tu nombre NO bonito. Lo siento.");


                }
             
          

        }

        private void Conectarbtn_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9050);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
            }
            catch (SocketException)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            } 
        }

        private void Desconectarbtn_Click(object sender, EventArgs e)
        {
            // Se terminó el servicio. 
            // Nos desconectamos
            this.BackColor = Color.Gray;
            string mensaje = "0/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            // Envia el nombre y el password del registro con el código 1 y separado por /
            string mensaje = "1/" + Convert.ToString(UsuarioRegText.Text) + "/" + Convert.ToString(ContraseñaRegText.Text);
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            UsuarioRegText.Clear();
            ContraseñaRegText.Clear();
        }

        private void Logbtn_Click(object sender, EventArgs e)
        {
            // Envia el nombre y el password del login con el código 2 y separado por /
            string mensaje = "2/" + Convert.ToString(UsuarioLogText.Text) + "/" + Convert.ToString(ContraseñaLogText.Text);
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            UsuarioLogText.Clear();
            ContraseñaLogText.Clear();
        }

        private void ConsultaRegbtn_Click(object sender, EventArgs e)
        {
            string mensaje = "5/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

     
    }
}
