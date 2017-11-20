using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;


namespace ProyectoTecnicasProgramacion
{

    public partial class Form1 : Form
    {
        #region Global Variables
        bool isConnected = false;
        string[] ports;
        string[] valores = new string[7];
        string S1, S2, S3, S4, S5, S6, S7;
        private delegate void DelegateAccess(string action);

        string strIn;
        string strOut;

        int caso = 0;
        string algorithum = "3"; //3 right, 2 left
        bool rightCorner;
        bool cross;
        bool alley;

        Graphics fromGrphics;
        Bitmap myBitmap;
        Pen myPen;
        List<PointF> points = new List<PointF>();
        PointF[] puntos = new PointF[1];
        string direction;
        #endregion


        private void AccessFrom(string action)
        {
            //Drawing
            //string direction = "";
            //if (radioAbajo.Checked)
            //{
            //    direction = radioAbajo.Text;
            //}
            //if (radioArriba.Checked)
            //{
            //    direction = radioArriba.Text;
            //}
            //if (radioDerecha.Checked)
            //{
            //    direction = radioDerecha.Text;
            //}
            //if (radioIzq.Checked)
            //{
            //    direction = radioIzq.Text;
            //}
            //DrawPath(direction);

            

            //Left of right algorithum (3: right | 2: left)
            if (radioLeft.Checked) algorithum = "2";
            else algorithum = "3";
            
            ReadData(action);
            txtNode.Text = caso.ToString();
            rightCorner =  (S4 == "0" && S5 == "0" && S6 == "1" && S7 == "1") || (S4 == "1" && S5 == "0" && S6 == "1" && S7 == "1");
            cross = (S1 == "1" && S2 == "1" && S3 == "1" && S4 == "1" && S5 == "0" && S6 == "0" && S7 == "1") || (S1 == "1" && S2 == "1" && S3 == "0" && S4 == "1" && S5 == "0" && S6 == "0" && S7 == "1");// || (S1 == "0" && S2 == "1" && S3 == "1" && S4 == "1" && S5 == "0" && S6 == "0" && S7 == "1");
            alley = (S1 == "0" && S2 == "0" && S3 == "0" && S4 == "0" && S5 == "0" && S6 == "0" && S7 == "0");
            switch (caso)
            {
                case 0:
                    LineFollower();
                    direction = "arriba";
                    DrawPath(direction);
                    break;
                
                    
                    
                case 9://Right Corner
                    SendData("3");
                    direction = "derecha";
                    if (S2 == "0") caso = 9;
                    else if(S2 == "1")
                    {
                        caso = 0;
                    }
                    DrawPath(direction);
                    break;
                case 10: // Stop the Robot
                    SendData("4");
                    break;
                case 11: //Cross
                    SendData(algorithum);
                    if (algorithum == "3")
                    {
                        direction = "derecha";
                    }
                    if (algorithum == "2")
                    {
                        direction = "izquierda";
                    }
                    if (S2 == "0") caso = 11;
                    else if (S2 == "1")
                    {
                        caso = 0;
                    }
                    DrawPath(direction);
                    break;
            }
            
        }

        public void DrawPath(string direction)
        {

            if (direction == "derecha")
            {
                points.Add(new PointF(points.Last().X + 1, points.Last().Y));
            }
            if (direction == "izquierda")
            {
                points.Add(new PointF(points.Last().X - 1, points.Last().Y));
            }
            if (direction == "arriba")
            {
                points.Add(new PointF(points.Last().X, points.Last().Y + 1));
            }
            if (direction == "abajo")
            {
                points.Add(new PointF(points.Last().X, points.Last().Y - 1));
            }



            fromGrphics.DrawLine(myPen, points[points.Count - 2], points.Last());
            pictureBox1.Image = myBitmap;
        }

        private void InterruptionAccess(string action)
        {
            DelegateAccess access = new DelegateAccess(AccessFrom);
            object[] args = { action };
            base.Invoke(access, args);
        }

        public Form1()
        {
            InitializeComponent();
            disableControls();
            getAvailablePorts();
            

        }

        private void connectArduino()
        {

            try
            {
                isConnected = true;
                string selectedPort = cboCom.GetItemText(cboCom.SelectedItem);
                port.PortName = selectedPort;
                port.BaudRate = 9600;
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Handshake = Handshake.None;

                port.Open();
                //port.Write("#Started\n");
                btnConnection.Text = "Desconectar";

                groupSensors.Enabled = true;
                groupConnection.Enabled = true;
                groupBox3.Enabled = true;
                //MessageBox.Show("Arduino Conectado");
            }
            catch (Exception E)
            {
                MessageBox.Show("No fue posible detectar algun dispositivo conectado.");
                
            }

            //Drawing Path Initialization
            myBitmap = new Bitmap(500, 500);
            fromGrphics = Graphics.FromImage(myBitmap);
            fromGrphics.Clear(Color.White);
            fromGrphics.TranslateTransform(myBitmap.Width / 2, myBitmap.Height / 2);
            fromGrphics.ScaleTransform(1, -1);
            myPen = new Pen(Color.Black, 3);
            points.Add(new PointF(0, 0));



        }

        private void getAvailablePorts()
        {
            ports = SerialPort.GetPortNames();
            //Check available ports and show it on the combobox
            foreach (string port in ports)
            {
                cboCom.Items.Add(port);
                if (ports[0] != null)
                {
                    
                    groupConnection.Enabled = true;
                    cboCom.SelectedItem = ports[0];
                }

            }
        }

        private void disableControls()
        {
            groupSensors.Enabled = false;
            groupConnection.Enabled = false;
            groupBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isConnected == false)
            {
                connectArduino();

            }
            else
            {
                disconnectArduino();
            }
        }

        private void disconnectArduino()
        {
            try
            {
                isConnected = false;
                port.Write("4");
                port.Close();
                btnConnection.Text = "Conectar";
                disableControls();
                fromGrphics.Clear(Color.White);
                pictureBox1.Image = myBitmap;
            }
            catch (Exception)
            {

                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getAvailablePorts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            strOut = txtMotors.Text;
            //Cleans the buffer port
            port.DiscardInBuffer();
            
            //Writes on the selected port
            port.Write(strOut);
        }

        private void Received(object sender, SerialDataReceivedEventArgs e)
        {
            InterruptionAccess(port.ReadExisting());
        }

        private void SendData(string data)
        {
            try
            {
                port.Write(data);
                txtMotors.Text = data;


            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.ToString());
            }
            

        }

        private void ReadData(string action)
        {
            if (action.Length > 20)
            {
                //Variables
                string sensores = "";

                //Recibe la cadena de caracteres del Microcontrolador
                strIn = action;



                //Separa la cadena de caracteres 
                char[] separador = { '\n' };
                string[] entrada = strIn.Split(separador);



                if (entrada[1].Length == 13)
                {
                    sensores = entrada[1];
                    char[] separador2 = { ',' };
                    string[] entrada2 = sensores.Split(separador2);

                    for (int j = 0; j < entrada2.Length; j++)
                    {
                        valores[j] = entrada2[j];
                    }

                    txtIn.Text = sensores;


                    S1 = valores[0];
                    S2 = valores[1];
                    S3 = valores[2];
                    S4 = valores[3];
                    S5 = valores[4];
                    S6 = valores[5];
                    S7 = valores[6];


                }
                

            }


            #region Sensors Monitor
            if (S1 == "1")
            {
                btnS1.BackColor = Color.Black;
                btnS1.ForeColor = Color.White;
            }
            else if (S1 == "0")
            {
                btnS1.BackColor = Color.White;
                btnS1.ForeColor = Color.Black;
            }

            if (S2 == "1")
            {
                btnS2.BackColor = Color.Black;
                btnS2.ForeColor = Color.White;
            }
            else if (S2 == "0")
            {
                btnS2.BackColor = Color.White;
                btnS2.ForeColor = Color.Black;
            }

            if (S3 == "1")
            {
                btnS3.BackColor = Color.Black;
                btnS3.ForeColor = Color.White;
            }
            else if (S3 == "0")
            {
                btnS3.BackColor = Color.White;
                btnS3.ForeColor = Color.Black;
            }

            if (S4 == "1")
            {
                btnS4.BackColor = Color.Black;
                btnS4.ForeColor = Color.White;
            }
            else if (S4 == "0")
            {
                btnS4.BackColor = Color.White;
                btnS4.ForeColor = Color.Black;
            }

            if (S5 == "1")
            {
                btnS5.BackColor = Color.Black;
                btnS5.ForeColor = Color.White;
            }
            else if (S5 == "0")
            {
                btnS5.BackColor = Color.White;
                btnS5.ForeColor = Color.Black;
            }

            if (S6 == "1")
            {
                btnS6.BackColor = Color.Black;
                btnS6.ForeColor = Color.White;
            }
            else if (S6 == "0")
            {
                btnS6.BackColor = Color.White;
                btnS6.ForeColor = Color.Black;
            }

            if (S7 == "1")
            {
                btnS7.BackColor = Color.Black;
                btnS7.ForeColor = Color.White;
            }
            else if (S7 == "0")
            {
                btnS7.BackColor = Color.White;
                btnS7.ForeColor = Color.Black;
            }


            #endregion
        }

        public string SensoresTraceros()
        {
            #region Sensores Traceros
            if (S4 == "0" && S5 == "0" && S6 == "0" && S7 == "0")//1
            {
                SendData("1");
                return "1";
            }
            else if (S4 == "0" && S5 == "0" && S6 == "0" && S7 == "1")//2
            {
                SendData("1");
                return "1";
            }
            else if (S4 == "0" && S5 == "0" && S6 == "1" && S7 == "0")//3
            {
                SendData("1");
                return "1";
            }
            else if (S4 == "0" && S5 == "0" && S6 == "1" && S7 == "1")//4
            {
                SendData("2");
                return "2";
            }
            else if (S4 == "0" && S5 == "1" && S6 == "0" && S7 == "0")//5
            {
                SendData("1");
                return "1";
            }
            else if (S4 == "0" && S5 == "1" && S6 == "0" && S7 == "1")//6
            {
                SendData("1");
                return "1";
            }
            else if (S4 == "0" && S5 == "1" && S6 == "1" && S7 == "0")//7
            {
                SendData("1");
                return "1";
            }
            else if (S4 == "0" && S5 == "1" && S6 == "1" && S7 == "1")//8
            {
                SendData("2");
                return "2";
            }
            else if (S4 == "1" && S5 == "0" && S6 == "0" && S7 == "0")//9
            {
                SendData("1");
                return "1";
            }
            else if (S4 == "1" && S5 == "0" && S6 == "0" && S7 == "1")//10
            {
                SendData("1");
                return "1";
            }
            else if (S4 == "1" && S5 == "0" && S6 == "1" && S7 == "0")//11
            {
                SendData("1");
                return "1";
            }
            else if (S4 == "1" && S5 == "0" && S6 == "1" && S7 == "1")//12
            {
                SendData("2");
                return "2";
            }
            else if (S4 == "1" && S5 == "1" && S6 == "0" && S7 == "0")//13
            {
                SendData("1");
                return "1";
            }
            else if (S4 == "1" && S5 == "1" && S6 == "0" && S7 == "1")//14
            {
                SendData("1");
                return "1";
            }
            else if (S4 == "1" && S5 == "1" && S6 == "1" && S7 == "0")//15
            {
                SendData("2");
                return "2";
            }
            else //16
            {
                SendData("2");
                return "2";
            }

            
            #endregion

            
        }

        public void LineFollower()
        {
            #region Sensores Delanteros
            if (alley)
            {
                caso = 11;
                return;
            }
            if (cross)
            {
                caso = 11;
                return;
            }
            else if (S1 == "1" && S2 == "1" && S3 == "1")//1
            {
                SendData("1");
                caso = 0;
                return;
            }
            else if (S1 == "1" && S2 == "1" && S3 == "0")//2
            {
                SendData("1");
                caso = 0;
                return;
            }
            else if (S1 == "1" && S2 == "0" && S3 == "1")//3
            {
                

                SendData("1");
                caso = 0;
                return;
            }
            else if (S1 == "1" && S2 == "0" && S3 == "0")//4
            {
                SendData("2");
                caso = 0;
                return;
            }
            else if (S1 == "0" && S2 == "1" && S3 == "1")//5
            {
                
                SendData("1");
                caso = 0;
                return;
            }
            else if (S1 == "0" && S2 == "1" && S3 == "0")//6
            {
                
                SendData("1");
                caso = 0;
                return;
            }
            else if (S1 == "0" && S2 == "0" && S3 == "1")//7
            {
                
                SendData("3");
                caso = 0;
                return;
            }
            else if (S1 == "0" && S2 == "0" && S3 == "0")//8
            {
                
                if (rightCorner)
                {
                    caso = 9;
                }
                else
                {
                    SendData("1");
                    caso = 0;
                }
                return;

            }


            #endregion

        }

    }
}
