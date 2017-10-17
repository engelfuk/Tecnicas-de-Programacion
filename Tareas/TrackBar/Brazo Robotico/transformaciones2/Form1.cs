using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transformaciones;
using System.IO;
using System.Threading;

namespace transformaciones2
{
    public partial class Form1 : Form
    {
        Pen plumaNegra;
        Pen plumaGreen;
        Pen plumaRed;
        Eslabon eslabon1;
        Eslabon eslabon2;
        Eslabon eslabon3;
        

        double th1;
        double th2;
        double th3;
        string ruta = @"C:\Users\engel\OneDrive - UNIVERSIDAD NACIONAL AUTÓNOMA DE MÉXICO\Semestre 7\Tecnicas de Programacion\Tareas\TrackBar\Brazo Robotico\datosPuntos.txt";


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region  Inicializacion de Variables de Clase
            PointF pt0 = new PointF(0, 0);
            PointF pt1 = new PointF(100, 0);
            PointF pt2 = new PointF(200, 0);
            PointF pt3 = new PointF(250, 0);

            plumaNegra = new Pen(Color.Black, 20);
            plumaGreen = new Pen(Color.Green, 20);
            plumaRed = new Pen(Color.Red, 20);
            eslabon1 = new Eslabon(pt0, pt1, plumaNegra);
            eslabon2 = new Eslabon(pt1, pt2, plumaRed);
            eslabon3 = new Eslabon(pt2, pt3, plumaGreen);

            File.Delete(ruta);

            

            #endregion

        }


        private void button1_Click(object sender, EventArgs e)
        {
            main();
            File.Delete(ruta);
        }

        public void main()
        {
            ImprimeEtiquetas();

            th1 = trackBar1.Value;
            th2 = trackBar2.Value;
            th3 = trackBar3.Value;

            StreamWriter escrituraPuntos;
            //escrituraPuntos = File.CreateText(ruta);
            escrituraPuntos =  File.AppendText(ruta);
            escrituraPuntos.Write(th1);
            escrituraPuntos.Write("\t");
            escrituraPuntos.Write(th2);
            escrituraPuntos.Write("\t");
            escrituraPuntos.Write(th3);
            escrituraPuntos.WriteLine("");


            pictureBox1.Image = eslabon1.DibujaBrazo(eslabon1, eslabon2, eslabon3);
            eslabon1.RotEslabon1(th1);
            eslabon2.RotEslabon2(th1, th2, eslabon1);
            eslabon3.RotEslabon3(th1, th2, th3, eslabon2, eslabon1);

            escrituraPuntos.Close();


        }


        public void ImprimeEtiquetas()
        {
            labelX1.Text = eslabon1.GetPos2.X.ToString();
            labelY1.Text = eslabon1.GetPos2.Y.ToString();
            labelAngulo1.Text = th1.ToString();

            labelX2.Text = eslabon2.GetPos2.X.ToString();
            labelY2.Text = eslabon2.GetPos2.Y.ToString();
            labelAngulo2.Text = th2.ToString();

            labelX3.Text = eslabon3.GetPos2.X.ToString();
            labelY3.Text = eslabon3.GetPos2.Y.ToString();
            labelAngulo3.Text = th3.ToString();
        }

        #region forms

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            main();
        }
        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            main();
        }
        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            main();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Rotacion()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void theta_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }


        #endregion

        private void Btn_Reproducir_Click(object sender, EventArgs e)
        {
            
            ReproduceTrayectoria();
        }

        

        public void ReproduceTrayectoria()
        {
            char[] separadores = { '\t' };
            string[] campos;
            StreamReader lectura = File.OpenText(ruta);
            string cadena;
            cadena = lectura.ReadLine();


            while (cadena != null)
            {
                campos = cadena.Split(separadores);
                th1 = Convert.ToDouble((campos[0]));
                th2 = Convert.ToDouble((campos[1]));
                th3 = Convert.ToDouble((campos[2]));

                eslabon1.RotEslabon1(th1);
                eslabon2.RotEslabon2(th1, th2, eslabon1);
                eslabon3.RotEslabon3(th1, th2, th3, eslabon2, eslabon1);

                cadena = lectura.ReadLine();

                ImprimeEtiquetas();
                pictureBox1.Image = eslabon1.DibujaBrazo(eslabon1, eslabon2, eslabon3);

                MessageBox.Show("Siguiente Punto");

            }

            lectura.Close();



        }

        private void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void Btn_sig_pto_Click(object sender, EventArgs e)
        {

        }

        private void Btn_borrar_ptos_Click(object sender, EventArgs e)
        {
            File.Delete(ruta);
        }
    }
}