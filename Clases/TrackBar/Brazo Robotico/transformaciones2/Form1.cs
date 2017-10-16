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

namespace transformaciones2
{
    public partial class Form1 : Form
    {
        double angulo;
        double angulo2;
        double angulo3;
        Eslabon eslabon1;
        Eslabon eslabon2;
        Eslabon eslabon3;


        PointF origen = new PointF(0, 0);

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region  Inicializacion de Variables de Clase

            Graphics fromGraphics = pictureBox1.CreateGraphics();
            eslabon1 = new Eslabon(origen, new PointF(120, 0), pictureBox1, fromGraphics);
            eslabon2 = new Eslabon(new PointF(120, 0), new PointF(250, 0), pictureBox1, fromGraphics);
            eslabon3 = new Eslabon(new PointF(250, 0), new PointF(300, 0), pictureBox1, fromGraphics);



            //eslabon1 = new Eslabon(origen, new PointF(120, 0), pictureBox1, fromGraphics);
            //eslabon2 = new Eslabon(new PointF(120, 0), new PointF(250, 0), pictureBox1, fromGraphics);
            //eslabon3 = new Eslabon(new PointF(250, 0), new PointF(300, 0), pictureBox1, fromGraphics);

            //pictureBox1.CreateGraphics();
            //plano.DibujarPlano();

            angulo = trackBar1.Value;
            angulo2 = trackBar2.Value;
            angulo3 = trackBar3.Value;

            #endregion

        }


        private void button1_Click(object sender, EventArgs e)
        {
            main();

        }

        public void main()
        {
            

            


            //fromGraphics.Clear(Color.AliceBlue);
            angulo = trackBar1.Value;
            angulo2 = trackBar2.Value;
            angulo3 = trackBar3.Value;

            //pictureBox1.Refresh();
            
            //plano.DibujarPlano();
            

            eslabon1.DibujaEslabon(new Pen(Color.Blue, 20));
            eslabon2.DibujaEslabon(new Pen(Color.Red, 20));
            eslabon3.DibujaEslabon(new Pen(Color.Green, 20));

            eslabon1.RotEslabon1(angulo, angulo2);
            eslabon2.RotEslabon2(angulo, angulo2, eslabon1);
            eslabon3.RotEslabon3(angulo, angulo2, angulo3, eslabon2, eslabon1);

            labelX1.Text = eslabon1.GetPos2.X.ToString();
            labelY1.Text = eslabon1.GetPos2.Y.ToString();
            labelAngulo1.Text = angulo.ToString();

            labelX2.Text = eslabon2.GetPos2.X.ToString();
            labelY2.Text = eslabon2.GetPos2.Y.ToString();
            labelAngulo2.Text = angulo2.ToString();

            labelX1.Text = eslabon1.GetPos2.X.ToString();
            labelY1.Text = eslabon1.GetPos2.Y.ToString();
            labelAngulo1.Text = angulo.ToString();

            labelX3.Text = eslabon3.GetPos2.X.ToString();
            labelY3.Text = eslabon3.GetPos2.Y.ToString();
            labelAngulo3.Text = angulo3.ToString();

            
        }

        #region forms

        
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
    }
}