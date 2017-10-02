using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exepcion_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double[] x = { 1, 2, 3 };
                double[] y = { 1, 2, 3 };


                dibujar();
                Plot graficar = new Plot(x, y);
            }
            catch (Exception error)
            {
                label1.Text = error.Message;
                
            }

            

        }

        private void dibujar()
        {
            Plot myPlot = new Plot();
            pictureBox1.Image = myPlot.bitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
