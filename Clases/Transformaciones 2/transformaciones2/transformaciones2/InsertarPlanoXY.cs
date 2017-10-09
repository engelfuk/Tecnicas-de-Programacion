using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Transformaciones
{
    class InsertarPlanoXY
    {

        #region Variables Globales
        private Bitmap fromBitmap;
        #endregion


        #region Constructores
        public InsertarPlanoXY()
        {
            this.fromBitmap = new Bitmap(2000, 2000);
            DibujarCuadricula();
            DibujarPlano();
        }



        #endregion

        #region Get y Set

        public Bitmap GetBitmap
        {
            get { return this.fromBitmap; }
        }

        #endregion

        #region Metodos 

        #region Publicos

        #endregion

        #region Privados
        private void DibujarPlano()
        {
            //DibujarCuadricula();
            Graphics fromGraphics = Graphics.FromImage(fromBitmap);
            
            //Dibuja un rectangulo que funciona como margen del plano cartesiano
            fromGraphics.DrawRectangle(new Pen(Color.Black, 8), 0, 0, fromBitmap.Width, fromBitmap.Height);

            //Generamos dos puntos para dibujar el eje Y
            PointF y0 = new PointF(fromBitmap.Width / 2, 0);
            PointF y1 = new PointF(fromBitmap.Width / 2, fromBitmap.Height);
            //Dibujamos el eje Y
            fromGraphics.DrawLine(new Pen(Color.Red, 2),y0,y1);

            //Generamos dos puntos para dibujar el eje X
            PointF x0 = new PointF(0,fromBitmap.Height / 2);
            PointF x1 = new PointF(fromBitmap.Width, fromBitmap.Height / 2);
            //Dibujamos el eje X
            fromGraphics.DrawLine(new Pen(Color.Red, 2), x0, x1);

        }

        private void DibujarCuadricula()
        {
            Graphics fromGraphics = Graphics.FromImage(fromBitmap);
            float origenX = fromBitmap.Width / 2;
            float origenY = fromBitmap.Height / 2;
            float divX = fromBitmap.Width / 21;
            float divY = fromBitmap.Height / 21;
            float incX = fromBitmap.Width / 80;
            float incY = fromBitmap.Height / 80;

            Pen plumaCuadricula = new Pen(Color.Gray, 2);

            for (int i = -22; i < 22; i++)
            {
                //Imprime las lineas verticales de la cuadricula
                fromGraphics.DrawLine(plumaCuadricula, origenX + i*divX, origenY + origenY, origenX + i*divX, origenY - origenY);
                //Imprime las lineas horizontales de la cuadricula
                fromGraphics.DrawLine(plumaCuadricula,origenX - origenX, origenY + i*divY,origenX + origenX, origenY + i*divY );

            }
            



            Pen plumaDivEjes = new Pen(Color.Red, 2);

            for (int i = -22; i < 22; i++)
            {
                //Imprime las diviciones horizontales del eje X
                fromGraphics.DrawLine(plumaDivEjes, origenX + i*divX, origenY + incY, origenX + i*divX, origenY - incY);
                //Imprime las diviciones verticales del eje y
                fromGraphics.DrawLine(plumaDivEjes, origenX - incX, origenY + i*divY, origenX + incX, origenY + i*divY);
                //Imprime los numeros eje horizontal
                fromGraphics.DrawString(i.ToString(), new Font(FontFamily.GenericSansSerif, 25), new SolidBrush(Color.Gray), origenX + i*divX, origenY);
                //Imprime los numeros eje vertical
                fromGraphics.DrawString(i.ToString(), new Font(FontFamily.GenericSansSerif, 25), new SolidBrush(Color.Gray), origenX , origenY + -i * divY);
            }

           

        }
        #endregion

        #endregion
    }
}
