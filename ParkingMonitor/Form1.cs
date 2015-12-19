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

namespace ParkingMonitor
{

    public partial class Form1 : Form
    {

        int valor;
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
            
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
            
        }
        int a = 0;
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            try{
            while (a != 1){
                String cadena = serialPort1.ReadLine();
                string[] separa = cadena.Split(new char[]{' '});
                string AX=separa[0];
                    Console.Write(separa[1]);
                valor=Convert.ToInt32(separa[1]);

                string[] lugar = AX.Split(new char[] { '.' });
                MuestraImagen(lugar[1]);
                


               
                }
            }
            catch(System.IO.IOException c)
{
}
            }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MuestraImagen(string lugar) {
            Boolean x=false;
            switch(Convert.ToInt32(lugar)){
                    
                case 0:
                    if (valor > 800)
                    {
                        x = true;
                    }
                    else
                    {
                        if (valor < 800)
                        {
                            x = false;
                        }

                    }
                    if (x == true)
                    {
                        A0.BackgroundImage = Image.FromFile("pmb.jpg");
                    }
                    else
                    {
                        A0.BackgroundImage = Image.FromFile("fondo.jpg");
                    }
                        x = false;
                    
                    break;
                case 1:
                    if (valor > 900)
                    {
                        x = true;
                    }
                    else
                    {
                        if (valor < 900)
                        {
                            x = false;
                        }

                    }
                    if (x == true)
                    {
                        A1.BackgroundImage = Image.FromFile("pma.jpg");
                    }
                    else
                    {
                        A1.BackgroundImage = Image.FromFile("fondo.jpg");
                    }
                    x = false;
                    break;

                case 2:
                    if (valor > 500)
                    {
                        x = true;
                    }
                    else
                    {
                            x = false;

                    }
                    if (x == true)
                    {
                        A2.BackgroundImage = Image.FromFile("pmb.jpg");
                    }
                    else
                    {
                        A2.BackgroundImage = Image.FromFile("fondo.jpg");
                    }
                    x = false;
                    break;

                case 3:
                    if (valor > 800)
                    {
                        x = true;
                    }
                    else
                    {
                        x = false;

                    }
                    if (x == true)
                    {
                        A3.BackgroundImage = Image.FromFile("pma.jpg");
                    }
                    else
                    {
                        A3.BackgroundImage = Image.FromFile("fondo.jpg");
                    }
                    x = false;
                    break;

                case 4:
                    if (valor > 900)
                    {
                        x = false;
                    }
                    else
                    {
                        if (valor < 870)
                        {
                            x = true;
                        }

                    }
                    if (x == true)
                    {
                        A4.BackgroundImage = Image.FromFile("pma.jpg");
                    }
                    else
                    {
                        A4.BackgroundImage = Image.FromFile("fondo.jpg");
                    }
                    x = false;
                    break;

                case 5:
                    if (valor > 700)
                    {
                        x = true;
                    }
                    else
                    {
                            x = false;
                        

                    }
                    if (x == true)
                    {
                        A5.BackgroundImage = Image.FromFile("pmb.jpg");
                    }
                    else
                    {
                        A5.BackgroundImage = Image.FromFile("fondo.jpg");
                    }
                    x = false;
                    break;
            }
        
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




    }
}
