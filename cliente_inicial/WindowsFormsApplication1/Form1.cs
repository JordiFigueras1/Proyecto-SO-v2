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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   
        private void Button2_Click(object sender, EventArgs e)
        {
            // Envia el nombre y el password del registro con el código 1 y separado por /
            string mensaje = "1/"+Convert.ToString (nombre_registro.Text)+"/"+Convert.ToString (password_registro.Text);
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('/')[0];
            if (Convert.ToInt32(mensaje) == 1)
            {
                MessageBox.Show("Registro ok");
            }
            else { MessageBox.Show("Registro fallido"); }
            nombre_registro.Clear();
            password_registro.Clear();
        }
               

        private void Button3_Click(object sender, EventArgs e)
        {
           // Se terminó el servicio. 
                // Nos desconectamos
                this.BackColor = Color.Gray;
                dataGridView1.Rows.Clear();
                string mensaje = "0/";
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
                server.Shutdown(SocketShutdown.Both);
                server.Close();

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            IPAddress direc = IPAddress.Parse("192.168.56.101");
            IPEndPoint ipep = new IPEndPoint(direc, 9250);



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

        private void Button_login_Click(object sender, EventArgs e)
        {
          
            // Envia el nombre y el password del login con el código 2 y separado por /
            string mensaje = "2/" + Convert.ToString(nombre_login.Text) + "/" + Convert.ToString(password_login.Text);
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);


            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('/')[0];
            if (Convert.ToInt32(mensaje) == 2)
            {
                MessageBox.Show("login ok");
            }
            else { MessageBox.Show("login fallido"); }
            nombre_login.Clear();
            password_login.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string mensaje = "3/"+textBox2.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);


            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2);
            mensaje = mensaje.TrimEnd('\0');
            string[] trozos = mensaje.Split('/');
            if (Convert.ToInt32(trozos [0]) == 3)
            {
                MessageBox.Show("el jugador ha ganado:"+trozos[1]+"partidas");
            }
            else { MessageBox.Show("peticion fallida"); }
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mensaje = "4/" + Convert.ToString(textBox1.Text) +"/"+ Convert.ToString(textBox3.Text) ;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
             byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2);
            mensaje = mensaje.TrimEnd('\0');
            string[] trozos = mensaje.Split('/');
            if (Convert.ToInt32(trozos [0]) == 4)
            {
                MessageBox.Show("han jugado:"+trozos[1]+" partidas");
            }
            else { MessageBox.Show("peticion fallida"); }
            textBox1.Clear();
            textBox3.Clear();
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            string mensaje = "5/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);


            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2);
            mensaje = mensaje.TrimEnd('\0');
            string[] trozos = mensaje.Split('/');
            if (Convert.ToInt32(trozos [0]) == 5)
            {
                MessageBox.Show("hay:" + trozos [1] + "jugadores registrados");
            }
            else { MessageBox.Show("peticion fallida"); }
        }

        private void verconbtn_Click(object sender, EventArgs e)
        {
            string mensaje = "6/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);


            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2);
            mensaje = mensaje.TrimEnd('\0');
            string[] trozos = mensaje.Split('/');
            if (Convert.ToInt32(trozos[0]) == 6)
            {
                int f = Convert.ToInt32(trozos[1]);
                dataGridView1.RowCount = f;
                int i = 0;
                while (i < f)
                {
                    dataGridView1.Rows[i].Cells[0].Value = trozos[i + 2];
                    i++;
                }
            }
            else { MessageBox.Show("peticion fallida"); }
        }

       
    }
}
