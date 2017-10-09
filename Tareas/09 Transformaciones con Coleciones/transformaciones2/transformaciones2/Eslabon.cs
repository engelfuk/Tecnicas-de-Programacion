using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace transformaciones2
{
    class Eslabon
    {
        #region Variables Globales
        private PointF pt1;
        private PointF pt2;
        private Graphics papel;
        private PictureBox myPicturebox;

        private double angulo;
        private double velX;
        private double velY;
        private double velAngular;
        private double longitud;

        #endregion

        #region Constructores
        /// <summary>
        /// Construye un Eslabon en base a dos puntos en el plano
        /// </summary>
        /// <param name="pt1">Punto 1</param>
        /// <param name="pt2">Punto 2</param>
        public Eslabon(PointF pt1, PointF pt2)
        {
            this.pt1 = pt1;
            this.pt2 = pt2;
            CalculaLongitud();
            CalculaAngulo();

        }



        #endregion

        #region Sets y Gets
        public PointF GetPos1
        {
            get { return this.pt1; }
        }

        public PointF GetPos2
        {
            get { return this.pt2; }
        }

        public double GetAngulo
        {
            get
            {
                CalculaAngulo();
                return this.angulo;
            }
        }

        public double GetVelX
        {
            get { return this.velX; }
        }

        public double GetVelY
        {
            get { return this.velY; }
        }

        public double GetVelAngular
        {
            get
            {

                return this.velX;
            }
        }

        public double GetLongitud
        {
            get
            {
                this.longitud = CalculaLongitud();
                return this.longitud;
            }
        }

        #endregion

        #region Metodos

        #region Publicos
        public void DibujaEslabon(PictureBox picturebox, Graphics papel)
        {
            this.myPicturebox = picturebox;
            this.papel = papel;
            myPicturebox.CreateGraphics();
            papel.DrawLine(new Pen(Color.Black, 3), this.pt1, this.pt2);
            
        }
        #endregion

        #region Privados

        private double CalculaLongitud()
        {
            double x1 = this.pt1.X;
            double y1 = this.pt1.Y;
            double x2 = this.pt2.X;
            double y2 = this.pt2.Y;

            this.longitud = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            return this.longitud;
        }


        private double CalculaAngulo()
        {
            double x1 = this.pt1.X;
            double y1 = this.pt1.Y;
            double x2 = this.pt2.X;
            double y2 = this.pt2.Y;

            this.longitud = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            this.angulo = Math.Atan2((y2 - y1), (x2 - x1));

            return this.angulo;
        }

        #endregion

        #endregion
    }
}
