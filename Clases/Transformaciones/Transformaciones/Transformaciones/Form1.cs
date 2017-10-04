using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InsertarPlanoXY plano = new InsertarPlanoXY();
            pictureBox1.Image = plano.GetBitmap;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void coordX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertarPlano()
        {
            Graphics fromGraphics;
            //fromGraphics.
        }


    }
}
