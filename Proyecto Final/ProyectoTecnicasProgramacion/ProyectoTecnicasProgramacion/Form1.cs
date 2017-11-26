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
        string[] ports;
        string S1, S2, S3, S4, S5, S6, S7;
        private delegate void DelegateAccess(string action);

        //Otras Variables
        //Almacena el caso anterior para despues reanudar
        int casoAnterior = 0;
        //Almacena el caso actual, se inicializa en 11 ya que ese estado es donde el robot esta parado
        int caso = 11;


        //Variables separarar la cadena enviada por el microcontrolador
        string strIn;
        string sensores = "";
        char[] separador = { ',' };
        string[] entrada;

        //Condiciones para detectar cruces
        bool rightCorner;
        bool leftCorner;
        bool cross;
        bool alley;
        bool eleIzquierda;
        bool eleDerecha;

        
        //Trayectoria de giros para llegar  las mesas
        // "2" Giro a la Izquierda
        // "3" Giro a la Derecha
        string[] mesa1Ida = { "2" };
        string[] mesa1Regreso = { "3" };
        string[] mesa2Ida = { "3", "3"};
        string[] mesa2Regreso = { "2", "2" };
        string[] mesa3Ida = { "3", "2", "3" };
        string[] mesa3Regreso = { "2", "3", "2" };
        string[] mesa4Ida = { "3", "2", "2" };
        string[] mesa4Regreso = { "3", "3", "2" };
        string[] trayectoriaIda;
        string[] trayectoriaRegreso;
        bool regreso = false;
        int numCruce;

        //Condiciones de sigue linea para los sensores Delanteros
        bool SigueLinea1;
        bool SigueLinea2;
        bool SigueLinea3;
        bool SigueLinea4;
        bool SigueLinea5;
        bool SigueLinea6;
        bool SigueLinea7;
        bool SigueLinea8;


        #endregion

        //Metodo Principal
        private void AccessFrom(string action)
        {
            //Seleccion de Trayectoria Mesa
            if (radioMesa1.Checked)
            {
                trayectoriaIda = mesa1Ida;
                trayectoriaRegreso = mesa1Regreso;
            }
            else if (radioMesa2.Checked)
            {
                trayectoriaIda = mesa2Ida;
                trayectoriaRegreso = mesa2Regreso;
            }
            else if (radioMesa3.Checked)
            {
                trayectoriaIda = mesa3Ida;
                trayectoriaRegreso = mesa3Regreso;
            }
            else if (radioMesa4.Checked)
            {
                trayectoriaIda = mesa4Ida;
                trayectoriaRegreso = mesa4Regreso;
            }

            ReadData(action);
            SigueLinea1 = (S1 == "1" && S2 == "1" && S3 == "1");
            SigueLinea2 = (S1 == "1" && S2 == "1" && S3 == "0");
            SigueLinea3 = (S1 == "1" && S2 == "0" && S3 == "1");
            SigueLinea4 = (S1 == "1" && S2 == "0" && S3 == "0");
            SigueLinea5 = (S1 == "0" && S2 == "1" && S3 == "1");
            SigueLinea6 = (S1 == "0" && S2 == "1" && S3 == "0");//Caso ideal
            SigueLinea7 = (S1 == "0" && S2 == "0" && S3 == "1");
            SigueLinea8 = (S1 == "0" && S2 == "0" && S3 == "0");
            leftCorner  = (S4 == "0" && S5 == "0" && S6 == "1" && S7 == "1");
            rightCorner = (S4 == "0" && S5 == "1" && S6 == "0" && S7 == "1");
            cross       = (S4 == "0" && S5 == "1" && S6 == "1" && S7 == "1") || (S4 == "1" && S5 == "1" && S6 == "1" && S7 == "1");
            alley       = (S4 == "0" && S5 == "0" && S6 == "0" && S7 == "0");
            eleIzquierda = (S1 == "0" && S2 == "1" && S3 == "0") && (S4 == "1" && S5 == "1" && S6 == "0" && S7 == "1");
            eleDerecha = (S1 == "0" && S2 == "1" && S3 == "0") && (S4 == "1" && S5 == "0" && S6 == "1" && S7 == "1");
            label1.Text = numCruce.ToString() + " " + regreso.ToString();
            
            switch (caso)
            {
                //Sensores Delanteros Configuracion
                case 0:
                    txtNode.Text = caso.ToString();
                    SendData("4");
                    if (SigueLinea1) caso = 1;
                    if (SigueLinea2) caso = 2;
                    if (SigueLinea3) caso = 3;
                    if (SigueLinea4) caso = 4;
                    if (SigueLinea5) caso = 5;
                    if (SigueLinea6) caso = 6;
                    if (SigueLinea7) caso = 7;
                    if (SigueLinea8) caso = 8;
                    break;
                //Sigue Linea
                case 1:
                    txtNode.Text = caso.ToString();
                    SendData("1");
                    if (!SigueLinea1) caso = 0;
                    break;
                //Sigue Linea
                case 2:
                    txtNode.Text = caso.ToString();
                    SendData("1");
                    if (!SigueLinea2) caso = 0;
                    if (cross) caso = 9;
                    if (alley) caso = 9;
                    if (leftCorner) caso = 10;
                    if (rightCorner) caso = 9;
                    break;
                //Sigue Linea
                case 3:
                    txtNode.Text = caso.ToString();
                    SendData("1");
                    if (!SigueLinea3) caso = 0;
                    break;
                //Sigue Linea
                case 4:
                    txtNode.Text = caso.ToString();
                    SendData("2");
                    if (!SigueLinea4) caso = 0;
                    break;
                //Sigue Linea
                case 5:
                    txtNode.Text = caso.ToString();
                    SendData("1");
                    if (!SigueLinea5) caso = 0;
                    break;
                //Sigue Linea Caso Ideal, se detectan los cruces Ele Derecha y Ele Izquierda
                case 6:
                    txtNode.Text = caso.ToString();
                    SendData("1");
                    if (!SigueLinea6) caso = 0;
                    if (eleDerecha)
                    {
                        //SendData("4");
                        //MessageBox.Show("Ele Derecha");
                        SendData("3");
                        Thread.Sleep(500);
                        caso = 12;
                        return;
                    }
                    if (eleIzquierda)
                    {
                        //SendData("4");
                        //MessageBox.Show("Ele Izquierda");
                        SendData("2");
                        Thread.Sleep(500);
                        caso = 12;
                        return;
                    }

                    break;
                //Sigue Linea
                case 7:
                    txtNode.Text = caso.ToString();
                    SendData("3");
                    if (!SigueLinea7) caso = 0;
                    //if (rightCorner) caso = 9;
                    break;
                //Sigue Linea Se Detectan los cruces T, callejon y se mantiene el robor en la linea
                case 8:
                    txtNode.Text = caso.ToString();
                    
                    if (((S4 == "1" || S7 == "1") && (S5 == "0" && S6 == "0")) || (S4 == "0" && S5 == "1" && S6 == "1" && S7 == "0"))//Correccion Trayeectoria
                    {
                        SendData("1");
                        caso = 0;
                        return;
                    }
                    if ((S4 == "0" && S5 == "0" && S6 == "1" && S7 == "0") || (S4 == "1" && S7 == "1" && S5 == "1" && S6 == "0"))//Correccion Trayectoria
                    {
                        SendData("2");
                        caso = 0;
                        return;
                    }
                    if ((S4 == "0" && S5 == "1" && S6 == "0" && S7 == "0") || (S4 == "1" && S7 == "1" && S5 == "0" && S6 == "1"))//Correccion Trayectoria
                    {
                        SendData("3");
                        caso = 0;
                        return;
                    }
                    if (leftCorner)//Vuelta Derecha
                    {
                        caso = 9;
                        return;
                    }
                    if (rightCorner)//Vuelta Izquierda
                    {
                        caso = 10;
                        return;
                    }
                    if (cross)
                    {
                        SendData("1");
                        Thread.Sleep(200);
                        caso = 12;
                        return;
                    }
                    if (alley)
                    {
                        //Si el Robot Llega al inicio, se resetean las variables
                        if (regreso)
                        {
                            groupMesas.Enabled = true;
                            numCruce = 0;
                            regreso = false;
                            btnStop.Text = "Iniciar";
                            MessageBox.Show("El Robot LLegó a la Cocina");
                            caso = 11;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("El Robot LLegó a la Mesa");
                        }
                        
                        numCruce = 0;
                        regreso = true;
                        caso = 9;
                        return;
                    }
                    break;

                case 9: //Girar Derecha
                    txtNode.Text = caso.ToString();
                    SendData("3");
                    if (S2 == "1")
                    {
                        SendData("1");
                        Thread.Sleep(400);
                        caso = 0;
                    }
                    
                    break;
                case 10: //Girar Izquierda
                    txtNode.Text = caso.ToString();
                    SendData("2");
                    if (S2 == "1")
                    {
                        SendData("1");
                        Thread.Sleep(400);
                        caso = 0;
                    }
                    
                    break;

                case 11://Robot Parado
                    txtNode.Text = caso.ToString();
                    SendData("4");
                    break;
                case 12://Trayectoria Mesas, el Robot gira en las direcciones correspondientes
                    txtNode.Text = caso.ToString();
                    try
                    {
                        if (regreso)
                        {
                            SendData("4");

                            if (trayectoriaRegreso[numCruce] == "2")
                            {
                                caso = 10;
                                numCruce++;
                            }
                            else if (trayectoriaRegreso[numCruce] == "3")
                            {
                                caso = 9;
                                numCruce++;
                            }
                        }
                        else
                        {
                            if (trayectoriaIda[numCruce] == "2")
                            {
                                caso = 10;
                                numCruce++;
                            }
                            else if (trayectoriaIda[numCruce] == "3")
                            {
                                caso = 9;
                                numCruce++;
                            }
                        }
                    }
                    catch (Exception Err)
                    {
                        richTextBox1.Text = Err.ToString();
                    }
                    
                    
                    break;
                case 13:
                    txtNode.Text = caso.ToString();
                    SendData("4");
                    MessageBox.Show("El Robot Llegó a la Mesa");
                    regreso = true;
                    caso = 9;
                    break;
            }
            
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
            getAvailablePorts();
            groupConnection.Enabled = true;
            groupSensors.Enabled = false;
            groupMesas.Enabled = false;
            groupBox3.Enabled = false;


        }
        private void connectArduino()
        {
            //Realiza la Conección con el Microcontrolador
            try
            {
                string selectedPort = cboCom.GetItemText(cboCom.SelectedItem);
                port.PortName = selectedPort;
                port.BaudRate = 9600;
                port.DataBits = 8;
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.Handshake = Handshake.None;
                port.Open();
                
            }
            catch (Exception)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = ("No fue posible detectar algun dispositivo conectado.");

            }

            
            caso = 11;

            
        }
        private void getAvailablePorts()
        {
            cboCom.Items.Clear();
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
        private void button1_Click(object sender, EventArgs e)
        {
            //Habilita y Deshabiitla los controles dentro de la Interfaz
            if (btnConnection.Text == "Conectar")
            {
                connectArduino();
                btnConnection.Text = "Desconectar";
                btnConnection.BackColor = Color.Yellow;
                btnStop.BackColor = Color.DeepSkyBlue;
                groupSensors.Enabled = true;
                groupConnection.Enabled = true;
                groupBox3.Enabled = true;
                groupMesas.Enabled = true;
                btnFind.Enabled = false;
                
            }
            else if (btnConnection.Text == "Desconectar")
            {
                disconnectArduino();
                btnConnection.Text = "Conectar";
                btnConnection.BackColor = SystemColors.Control;
                btnFind.BackColor = Color.DeepSkyBlue;
                btnFind.Enabled = true;
            }
        }
        private void disconnectArduino()
        {
            //Realliza la desconccion entre el microcontrolador y la computadora
            try
            {
                port.Write("4");
                port.Close();
                btnConnection.Text = "Conectar";
                btnConnection.BackColor = Color.DeepSkyBlue;
                groupSensors.Enabled = false;
                groupConnection.Enabled = false;
                groupBox3.Enabled = false;
            }
            catch (Exception Err)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = Err.ToString();

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            getAvailablePorts();
            btnConnection.BackColor = Color.DeepSkyBlue;
            if (btnConnection.Text == "Conectar")
            {
                btnFind.BackColor = SystemColors.Control;
                btnFind.Enabled = false;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Inicia el Moviemiento del Robot
            if (btnStop.Text == "Iniciar")
            {
                caso = 0;
                btnStop.Text = "Detener";
                groupMesas.Enabled = false;
                return;
            }
            //Pone en espera al Robot
            if (btnStop.Text == "Detener")
            {
                casoAnterior = caso;
                caso = 11;
                btnStop.Text = "Continuar";
                return;
            }
            //Reanuda el movimiento del Robot
            if (btnStop.Text == "Continuar")
            {
                caso = casoAnterior;
                btnStop.Text = "Detener";
                return;
            }
           
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

            if (action.Length > 7)
            {
                //Recibe la cadena de caracteres del Microcontrolador
                strIn = action;
                //Separa la cadena de caracteres 
                entrada = strIn.Split(separador);


                for (int i = 0; i < entrada.Length; i++)
                {
                    if (entrada[i].Length == 7)
                    {
                        sensores = entrada[i];
                        char[] valores = sensores.ToCharArray();
                        txtIn.Text = sensores;
                        S1 = valores[0].ToString();
                        S2 = valores[1].ToString();
                        S3 = valores[2].ToString();
                        S4 = valores[3].ToString();
                        S5 = valores[4].ToString();
                        S6 = valores[5].ToString();
                        S7 = valores[6].ToString();

                        //Muestra en pantalla en color negro los sensores que dectectan linea y en blanco los que no.
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

                        break;
                    }
                }

            }


        }
        
        

    }

    
}
