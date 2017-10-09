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
        int i;
        PlanoXY plano;
        Graphics fromGraphics;
        PointF origen = new PointF(0, 0);
        List<PointF> puntosRotEslabon1;
        List<PointF> puntosRotEslabon2;
        Pen plumaEslabon = new Pen(Color.Black, 3);

        Eslabon eslabon1;
        Eslabon eslabon2;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Inicializacion de Variables de Clase
            
            puntosRotEslabon1 = new List<PointF>();
            puntosRotEslabon2 = new List<PointF>();
            pictureBox1.CreateGraphics();
            fromGraphics = pictureBox1.CreateGraphics();
            plano = new PlanoXY(pictureBox1, fromGraphics);
            
            plano.DibujarPlano();
            eslabon1 = new Eslabon(new PointF(0, 0), new PointF(150, 0));
            //puntosRotEslabon1.Add(eslabon1.GetPos2);
            eslabon2 = new Eslabon(new PointF(0, 0), new PointF(0, 80));
            //puntosRotEslabon2.Add(eslabon2.GetPos2);
            angulo = 0;
            
            i = 0;
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double angulo2 = angulo;
            if (angulo >= 360)
            {
                angulo -= 360;
            }
            

            pictureBox1.Refresh();

            //Dibuja el plano cartesiano
            plano.DibujarPlano();

            if (i == puntosRotEslabon1.Count)
            {
                i = 0;
            }



            

            //Calculo de Puntos
            double th1 = (angulo * Math.PI / 180);
            double th2 = 2*(angulo * Math.PI / 180);


            PointF pt1= new PointF(
                (float)(eslabon1.GetLongitud * Math.Cos(th1)),
                (float)(eslabon1.GetLongitud * Math.Sin(th1)));

            puntosRotEslabon1.Add(pt1);

            PointF pt2 = new PointF(
                (float)(eslabon1.GetLongitud * Math.Cos(th1) + eslabon2.GetLongitud * Math.Cos(th1 + th2)),
                (float)(eslabon1.GetLongitud * Math.Sin(th1) + eslabon2.GetLongitud * Math.Sin(th1 + th2)));

            puntosRotEslabon2.Add(pt2);

            

            
            //Impresion de Eslabon 1
            fromGraphics.DrawLine(plumaEslabon, origen, puntosRotEslabon1[i]);
            labelAngulo1.Text = (angulo).ToString() + "°";
            labelX1.Text = (puntosRotEslabon1[i].X).ToString();
            labelY1.Text = (puntosRotEslabon1[i].Y).ToString();

            if (th2 / Math.PI * 180 >= 360)
            {
                th2 -= 2*Math.PI;
            }

            //Impresion de Eslabon 2
            fromGraphics.DrawLine(plumaEslabon, puntosRotEslabon1[i], puntosRotEslabon2[i]);
            labelAngulo2.Text = (th2/Math.PI * 180).ToString() + "°";
            labelX2.Text = (puntosRotEslabon2[i].X).ToString();
            labelY2.Text = (puntosRotEslabon2[i].Y).ToString();

            i++;
            angulo++;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

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

        public void ImprimeEtiquetas()
        {

        }
    }
}