﻿using System;
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
        bool condicion = true;
        PlanoXY plano;
        Graphics fromGraphics;
        PointF origen = new PointF(0, 0);

        Eslabon eslabon1;
        Eslabon eslabon2;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Variables de Clase
            eslabon1 = new Eslabon(origen, new PointF(100, 0));
            eslabon2 = new Eslabon(new PointF(100, 0), new PointF(300, 0));

            pictureBox1.CreateGraphics();
            fromGraphics = pictureBox1.CreateGraphics();
            plano = new PlanoXY(pictureBox1, fromGraphics);

            plano.DibujarPlano();

            angulo = 0;
            
            #endregion

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (angulo < 68 && condicion)
            {

                main();

                angulo++;
                angulo2++;
            }
            else
            {
                angulo--;
                angulo2--;

                main();

                condicion = false;

                if (angulo == 0)
                {
                    condicion = true;
                }

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        public void main()
        {
            angulo2 = 2 * angulo;
            pictureBox1.Refresh();
            plano.DibujarPlano();

            eslabon1.DibujaEslabon(pictureBox1, fromGraphics, new Pen(Color.Blue, 20));
            eslabon2.DibujaEslabon(pictureBox1, fromGraphics, new Pen(Color.Red, 20));

            eslabon1.RotEslabon(angulo, angulo2);
            eslabon2.RotEslabon(angulo, angulo2, eslabon1);

            labelX1.Text = eslabon1.GetPos2.X.ToString();
            labelY1.Text = eslabon1.GetPos2.Y.ToString();
            labelAngulo1.Text = angulo.ToString();

            labelX2.Text = eslabon2.GetPos2.X.ToString();
            labelY2.Text = eslabon2.GetPos2.Y.ToString();
            labelAngulo2.Text = angulo2.ToString();
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

       
    }
}