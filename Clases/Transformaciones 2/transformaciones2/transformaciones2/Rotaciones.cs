using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Transformaciones;

namespace transformaciones2
{
    class Rotaciones:InsertarPlanoXY
    {
        #region Variables Globales
        private Bitmap fromBitmap;
        private float x;
        private float y;


        #endregion

        #region Constructores
        public Rotaciones(double grados, double x, double y)
        {
            this.fromBitmap = new Bitmap(3000, 3000);
            InsertarPlanoXY plano = new InsertarPlanoXY();
            this.fromBitmap = plano.GetBitmap;
            Rotacion((float)GradosToRad(grados),(float)x, (float)y);
        }
        #endregion

        #region Set y Get
        public Bitmap GetBitmap
        {
            get { return this.fromBitmap; }
        }

        public float GetCoodX
        {
            get { return this.x; }
        }

        public float GetCoodY
        {
            get { return this.y; }
        }

        #endregion

        #region Metodos

        #region Privados
        private double GradosToRad(double angulo)
        {
            return angulo * Math.PI / 180;
        }

        private void Rotacion(float angulo, float x1, float y1)
        {
            Graphics fromGraphics = Graphics.FromImage(fromBitmap);

            this.x = (float)(x1 * Math.Cos(angulo) - y1 * Math.Sin(angulo));
            this.y = (float)(y1 * Math.Cos(angulo) + x1 * Math.Sin(angulo));
            PointF origen = new PointF(x,y);

            fromGraphics.TranslateTransform(fromBitmap.Width / 2, fromBitmap.Height / 2);
            fromGraphics.ScaleTransform(1,-1);

            fromGraphics.DrawLine(new Pen(Color.Black,10), 0, 0, x, y);
            //return new PointF(x,y);

            


        }

        

        #endregion

        #endregion
    }
}
