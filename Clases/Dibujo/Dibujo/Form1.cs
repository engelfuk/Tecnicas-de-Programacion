using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dibujo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Bitmap b = new Bitmap(@"C:\Users\engel\Pictures\Eskimo.jpg");
            //pictureBox1.Image = b;

            Graphics papel;
            papel = pictureBox1.CreateGraphics();

            Pen lapiz = new Pen(Color.Red);
            //papel.DrawRectangle(lapiz,5,5,10,20);

            Rectangle box = new Rectangle(10, 15, 20, 30);

            //papel.DrawRectangle(lapiz,box);
            //papel.FillRectangle(Brushes.Red, box);
            //papel.FillEllipse(Brushes.Purple, box);
            //int margen = Convert.ToInt16(textBox1.Text);
            //int w = pictureBox1.Width - 2 * margen;
            //int h = pictureBox1.Height - 2 * margen;

            Rectangle caja = new Rectangle(10, 10, 20,30);
            papel.DrawRectangle(lapiz, caja);

            //int cX = pictureBox1.Width / 2;
            //int cY = pictureBox1.Height / 2;
            //Point p1 = new Point();
            //Point p2 = new Point(cX,0);
            //papel.DrawLine(lapiz, p1, p2);

            papel.DrawLine(lapiz, 0, pictureBox1.Height / 2, pictureBox1.Width / 2,pictureBox1.Height / 2);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
