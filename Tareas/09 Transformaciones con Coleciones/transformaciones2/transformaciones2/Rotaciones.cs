using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Transformaciones;

namespace transformaciones2
{
    class Rotaciones
    {
        #region Variables Globales
        private PointF punto;
        
        

        #endregion

        #region Constructores
        public Rotaciones()
        {

        }
        #endregion

        #region Set y Get
        
        public float GetCoodX
        {
            get{ return punto.X;}
        }

        public float GetCoodY
        {
            get { return punto.Y; }
        }

        #endregion

        #region Metodos
        #region Publicos
        public PointF RotacionZ(float angulo, PointF pt)
        {
            angulo = (float)GradosToRad(angulo);
            float x1 = (float)(pt.X * Math.Cos(angulo) - pt.Y * Math.Sin(angulo));
            float y1 = (float)(pt.Y * Math.Cos(angulo) + pt.X * Math.Sin(angulo));
            PointF punto = new PointF(x1, y1);


            return punto;
        }

        public PointF RotacionZ(float angulo, float x, float y)
        {
            angulo = (float)GradosToRad(angulo);
            float x1 = (float)(x * Math.Cos(angulo) - y * Math.Sin(angulo));
            float y1 = (float)(y * Math.Cos(angulo) + x * Math.Sin(angulo));
            PointF punto = new PointF(x1, y1);


            return punto;
        }

        public PointF Translacion(PointF pt1 , PointF pt2)
        {
            PointF suma = new PointF(pt1.X + pt2.X, pt1.Y + pt2.Y);

            return suma;
        }


        public PointF RotTrans(PointF pt, float angulo, PointF trans)
        {
            PointF rotTrans = Translacion(RotacionZ(angulo, pt), trans);

            return rotTrans;
        }
        #endregion

        #region Privados
        private double GradosToRad(double angulo)
        {
            return angulo * Math.PI / 180;
        }

        



        #endregion

        #endregion
    }
}