using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Transformaciones
{
    class PlanoXY
    {

        #region Variables Globales
        PictureBox picturebox;
        Graphics fromGraphics;
        #endregion


        #region Constructores
        /// <summary>
        /// Crea un objeto de tipo plano cartesiano
        /// </summary>
        /// <param name="pictureBox">contenedor donde se mostrara</param>
        /// <param name="graphics">lienzo</param>
        public PlanoXY(PictureBox pictureBox, Graphics graphics)
        {
            this.picturebox = pictureBox;
            this.picturebox.BackColor = Color.White;
            this.fromGraphics = graphics;
            this.fromGraphics.TranslateTransform(pictureBox.Width/2,pictureBox.Height/2);
            this.fromGraphics.ScaleTransform(1, -1);
            
            
            
        }



        #endregion

        #region Get y Set
        public Graphics GetPlano
        {
            get
            {
                return this.fromGraphics;
            }
        }


        #endregion

        #region Metodos 

        #region Publicos
        /// <summary>
        /// Diibuja un plano cartesiano
        /// </summary>
        public void DibujarPlano()
        {
            DibujarCuadricula();
            Plano();
            
            
        }
        #endregion
        /// <summary>
        /// Crea los ejes coordenados del plano cartesiano
        /// </summary>
        #region Privados
        private void Plano()
        {
            
            //Generamos dos puntos para dibujar el eje Y
            PointF y0 = new PointF(0, -picturebox.Height);
            PointF y1 = new PointF(0, picturebox.Height);
            //Dibujamos el eje Y
            fromGraphics.DrawLine(new Pen(Color.Red, 2),y0,y1);

            //Generamos dos puntos para dibujar el eje X
            PointF x0 = new PointF(-picturebox.Width, 0);
            PointF x1 = new PointF(picturebox.Width, 0);
            //Dibujamos el eje X
            fromGraphics.DrawLine(new Pen(Color.Red, 2), x0, x1);

        }
        /// <summary>
        /// Crea la cuadricula del plano cartesiano
        /// </summary>
        private void DibujarCuadricula()
        {
            
            float divX = picturebox.Width / 21;
            float divY = picturebox.Height / 21;
            float incX = picturebox.Width / 90;
            float incY = picturebox.Height / 90;
            Pen plumaCuadricula = new Pen(Color.Gray, 1);
            Pen plumaDivEjes = new Pen(Color.Red, 2);

            for (int i = -22; i < 22; i++)
            {
                //Imprime las lineas verticales de la cuadricula
                fromGraphics.DrawLine(plumaCuadricula, i*divX, -picturebox.Height/2, i*divX, picturebox.Height / 2);
                //Imprime las lineas horizontales de la cuadricula
                fromGraphics.DrawLine(plumaCuadricula, -picturebox.Width/2, i*divY, picturebox.Width/2, i*divY );

            }
            
            
            for (int i = -22; i < 22; i++)
            {
                //Imprime las diviciones horizontales del eje X
                fromGraphics.DrawLine(plumaDivEjes, i * divX, incY, i * divX, -incY);
                //Imprime las diviciones verticales del eje y
                fromGraphics.DrawLine(plumaDivEjes, -incX, i*divY, incX, i*divY);
                //Imprime los numeros eje horizontal
                fromGraphics.DrawString(i.ToString(), new Font(FontFamily.GenericSansSerif, 5), new SolidBrush(Color.Gray), i*divX, 0);
                //Imprime los numeros eje vertical
                fromGraphics.DrawString(i.ToString(), new Font(FontFamily.GenericSansSerif, 5), new SolidBrush(Color.Gray), 0 , -i * divY);
            }

           

        }
        #endregion

        #endregion
    }
}
