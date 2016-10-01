using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace ParkingMonitor
{

    public partial class Form1 : Form
    {
        int a = 0;
        //MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        

        int valor;
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
            
        }
        
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {







            try
            {
                while (a != 1)
                {
                    String cadena = serialPort1.ReadLine();
                    string[] separa = cadena.Split(new char[] { ' ' });
                    string AX = separa[0];
                        Console.Write(separa[1]);
                    valor = Convert.ToInt32(separa[1]);

                    string[] lugar = AX.Split(new char[] { '.' });
                    MuestraImagen(lugar[1]);
                }
            }
            finally {

            }
            }
        
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MuestraImagen(string lugar) {
            //builder.Server = "localhost";
            //builder.UserID = "root";
            //builder.Password = "theonly1";
            //builder.Database = "parking";
            //MySqlConnection conn = new MySqlConnection(builder.ToString());
            //MySqlCommand cmd = conn.CreateCommand();
            
            switch (Convert.ToInt32(lugar))
            {

                case 0:
                    if (valor > 850)
                    {
                        A0.BackgroundImage = Image.FromFile("Derecha2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A1'";
                    }
                    else
                    {
                        A0.BackgroundImage = Image.FromFile("fondo2.png");
                        //A1.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A1'";

                    }
                    break;


                case 1:
                    /*
                    if (valor > 650)
                    {*/
                        A1.BackgroundImage = Image.FromFile("Derecha6.png");
                    /*
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A2'";
                    }
                    else
                    {
                        A1.BackgroundImage = null;
                        A1.BackColor = Color.Transparent;
                        //A2.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A2'";
                    }
                    */
                    break;

                case 2:
                    if (valor > 970)
                    {
                        
                        A2.BackgroundImage = Image.FromFile("Derecha4.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A3'";
                    }
                    else
                    {
                        A2.BackgroundImage = Image.FromFile("fondo2.png");
                        //A3.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A3'";

                    }
                    break;

                case 3:
                    if (valor > 900)
                    {
                        A3.BackgroundImage = Image.FromFile("Derecha5.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A4'";
                    }
                    else
                    {
                        A3.BackgroundImage = Image.FromFile("fondo2.png");
                        //A4.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A4'";

                    }
                    break;

                case 4:
                    if (valor > 700)
                    {
                        
                        A4.BackgroundImage = Image.FromFile("Izquierda1.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A5'";
                    }
                    else
                    {
                        A4.BackgroundImage = Image.FromFile("fondo2.png");
                        //A5.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A5'";
                    }
                    break;

                case 5:
                    if (valor > 900)
                    {
                        A5.BackgroundImage = Image.FromFile("Izquierda3.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A6'";
                    }
                    else
                    {
                        A5.BackgroundImage = Image.FromFile("fondo2.png");
                        //A6.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A6'";
                    }
                    break;
                    
                case 6:
                    if (valor > 870)
                    {
                        A6.BackgroundImage = Image.FromFile("Izquierda2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A7'";
                    }
                    else
                    {
                        A6.BackgroundImage = Image.FromFile("fondo2.png");
                        //A7.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A7'";

                    }
                    break;

                case 7:
                    A7.BackgroundImage = Image.FromFile("Izquierda6.png");
                    /*
                    if (valor > 690)
                    {
                        A7.BackgroundImage = Image.FromFile("Izquierda6.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A8'";
                    }
                    else
                    {*/
                        //A7.BackgroundImage = Image.FromFile("fondo2.png");
                        //A8.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A8'";
                    //}
                    break;

                case 8:
                    if (valor > 850)
                    {
                        A8.BackgroundImage = Image.FromFile("Derecha3.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A9'";
                    }
                    else
                    {
                        A8.BackgroundImage = Image.FromFile("fondo2.png");
                        //A9.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A9'";
                    }
                    break;


                    //No funciona A9
                case 9:/*
                    if (valor > 5000)
                    {
                    */
                        A9.BackgroundImage = Image.FromFile("Derecha6.png");
                    /*
                    //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A10'";
                }
                else
                {
                    A9.BackgroundImage = null;
                    A9.BackColor = Color.Transparent;
                    //A10.BackgroundImage = Image.FromFile("fondo2.png");
                    //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A10'";


                }*/
                    break;

                case 10:
                    if (valor > 850)
                    {
                        A10.BackgroundImage = Image.FromFile("Derecha5.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A11'";
                    }
                    else
                    {
                        A10.BackgroundImage = Image.FromFile("fondo2.png");
                        //A11.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A11'";
                    }
                    break;

                case 11:
                    if (valor > 880)
                    {
                        A11.BackgroundImage = Image.FromFile("Derecha6.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A12'";
                    }
                    else
                    {
                        A11.BackgroundImage = Image.FromFile("fondo2.png");
                        //A12.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A12'";
                    }
                    break;

                case 12:
                    if (valor > 950)
                    {
                        A12.BackgroundImage = Image.FromFile("Izquierda3.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A13'";
                    }
                    else
                    {
                        A12.BackgroundImage = Image.FromFile("fondo2.png");
                        //A13.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A13'";
                    }
                    break;
                case 13:
                    if (valor > 950)
                    {
                        A13.BackgroundImage = Image.FromFile("Izquierda6.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A13'";
                    }
                    else
                    {
                        A13.BackgroundImage = Image.FromFile("fondo2.png");
                        //A14.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A13'";
                    }
                    break;
                case 14:
                    if (valor > 800)
                    {
                        A14.BackgroundImage = Image.FromFile("Izquierda2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A13'";
                    }
                    else
                    {
                        A14.BackgroundImage = Image.FromFile("fondo2.png");
                        //A15.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A13'";
                    }
                    break;
                case 15:
                    if (valor > 850)
                    {
                        A15.BackgroundImage = Image.FromFile("Izquierda5.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A13'";
                    }
                    else
                    {
                        A15.BackgroundImage = Image.FromFile("fondo2.png");
                        //A16.BackgroundImage = Image.FromFile("fondo2.png");
                        //cmd.CommandText = "UPDATE Cajones SET ValorSensor = '" + valor + "' WHERE letraCajon='A13'";
                    }
                    break;



            }
            //conn.Open();
            //cmd.ExecuteNonQuery();

        }
        


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (a == 0) { 
              DialogResult rs = MessageBox.Show("Desea Salir", "Mensaje", MessageBoxButtons.YesNo);
              if (rs == DialogResult.Yes)
              {
                  a = 1;
                  serialPort1.Close();
                  Application.Exit();
              }
              else
              {
                  if (rs == DialogResult.No)
                  {
                      e.Cancel = true;

                  }
              }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void A12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
