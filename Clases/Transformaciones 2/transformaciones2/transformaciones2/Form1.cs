using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Transformaciones;

namespace transformaciones2
{
    public partial class Form1 : Form
    {
        double angulo = 0;
        public Form1()
        {
            InitializeComponent();
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (angulo==360)
            {
                angulo = 0;
            }
            Rotaciones rot = new Rotaciones(angulo, 1000, 0);
            pictureBox1.Image = rot.GetBitmap;
            labelAngulo.Text = angulo++.ToString()+ "°";
            labelX.Text = rot.GetCoodX.ToString();
            labelY.Text = rot.GetCoodY.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void Rotacion()
        {
            //Bitmap fromBitmap = 
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



    }
}
