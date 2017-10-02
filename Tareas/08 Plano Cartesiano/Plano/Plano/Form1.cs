using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plano
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
                     
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCentral.Refresh();//Borra los elementos en pantalla
            DibujarCuadricula();
            
        }


        
        /// <summary>
        /// Dibuja los ejes coordenados de un plano cartesiano XY asi como una cuadricula auxiliar
        /// </summary>
        public void DibujarCuadricula()
        {
            //Se inicializa el entorno Graphics
            Graphics fromGraphics = panelCentral.CreateGraphics();
            Pen myPen = new Pen(Color.Gray, 1);

            //Variables
            int width = panelCentral.Width;
            int height = panelCentral.Height;
            int centroX = panelCentral.Width / 2;
            int centroY = panelCentral.Height / 2;
            int div = 20;

            for (int i = 0, n=-div/2 ; i < div; i++, n++)
            {
                //Cambia el color de linea para dibujar los ejes coordenados
                if (i== 0)
                {
                    myPen.Color = Color.Red;
                    myPen.Width = 2;
                  
                }
                else
                {
                    myPen.Color = Color.Gray;
                    myPen.Width = 1;
                }
                //Imprime la cuadricula del plano
                fromGraphics.DrawLine(myPen, centroX + i * width / div, 0, centroX + i * width / div, height);
                fromGraphics.DrawLine(myPen, centroX - i * width / div, 0, centroX - i * width / div, height);

                fromGraphics.DrawLine(myPen, 0, centroY + i * height / div, width, centroY + i * height / div);
                fromGraphics.DrawLine(myPen, 0, centroY - i * height / div, width, centroY - i * height / div);

                //Imprime los numeros en el eje X
                fromGraphics.DrawString(Convert.ToString(n), new Font("Arial", 10), new SolidBrush(Color.Black), i* width/div, height/2 );

                //Imprime los numeros en el eje Y
                fromGraphics.DrawString(Convert.ToString(-1*n), new Font("Arial", 10), new SolidBrush(Color.Black), width/2 , i*height/div);

            }

            

            



        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
