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
        private PointF pt1Inicial;
        private PointF pt2Inicial;
        private Graphics papel;
        private PictureBox myPicturebox;
        private List<PointF> pos1;
        private List<PointF> pos2;
        private Pen pluma  = new Pen(Color.Black,5);

        private double angulo;
        //private double velX;
        //private double velY;
        //private double velAngular;
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
            pos1 = new List<PointF>();
            pos2 = new List<PointF>();
            this.pt1Inicial = pt1;
            this.pt2Inicial = pt2;
            pos1.Add(pt1);
            pos2.Add(pt2);
            CalculaLongitud();
            CalculaAngulo();

        }



        #endregion

        #region Sets y Gets

        public List<PointF> GetListaPos1
        {
            get
            {
                return pos1;
            }
        }

        public List<PointF> GetListaPos2
        {
            get
            {
                return pos2;
            }
        }

        public PointF GetPos1
        {
            get { return pos1.Last(); }
        }

        public PointF GetPos2
        {
            get { return pos2.Last(); }
        }

        public double GetAngulo
        {
            get
            {
                CalculaAngulo();
                return this.angulo;
            }
        }

        //public double GetVelX
        //{
        //    get { return this.velX; }
        //}

        //public double GetVelY
        //{
        //    get { return this.velY; }
        //}

        //public double GetVelAngular
        //{
        //    get
        //    {

        //        return this.velX;
        //    }
        //}

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
            papel.DrawLine(pluma, this.pt1Inicial, this.pt2Inicial);
            
        }

        public void DibujaEslabon(PictureBox picturebox, Graphics papel, Pen pluma)
        {
            this.myPicturebox = picturebox;
            this.papel = papel;
            //myPicturebox.CreateGraphics();
            papel.DrawLine(pluma, pos1.Last(), pos2.Last());
            papel.DrawLine(new Pen(Color.White,pluma.Width/2), pos1.Last(), pos2.Last());
            papel.FillEllipse(new SolidBrush(Color.Gray), pos1.Last().X - pluma.Width, pos1.Last().Y - pluma.Width, (2 * pluma.Width), (2 * pluma.Width));
            papel.FillEllipse(new SolidBrush(Color.Gray), pos2.Last().X - pluma.Width, pos2.Last().Y - pluma.Width, (2 * pluma.Width), (2 * pluma.Width));

            

        }

        public void RotEslabon(double th1, double th2)
        {

            th1 *= Math.PI / 180;
            th2 *= Math.PI / 180;

            pos1.Add(new PointF(0, 0));


            PointF pt = new PointF(
                (float)(longitud * Math.Cos(th1)),
                (float)(longitud * Math.Sin(th1)));

            pos2.Add(pt);
            
        }

        public void RotEslabon(double th1, double th2, Eslabon eslabonAnterior)
        {
            
            pos1.Add(eslabonAnterior.GetListaPos2.Last());

            th1 *= Math.PI / 180;
            th2 *= Math.PI / 180;


            PointF pt = new PointF(
                (float)(eslabonAnterior.GetLongitud * Math.Cos(th1) + longitud * Math.Cos(th1 + th2)),
                (float)(eslabonAnterior.GetLongitud * Math.Sin(th1) + longitud * Math.Sin(th1 + th2)));

            pos2.Add(pt);

            
        }



        #endregion

        #region Privados

        private double CalculaLongitud()
        {
            double x1 = this.pt1Inicial.X;
            double y1 = this.pt1Inicial.Y;
            double x2 = this.pt2Inicial.X;
            double y2 = this.pt2Inicial.Y;

            this.longitud = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            return this.longitud;
        }


        private double CalculaAngulo()
        {
            double x1 = this.pt1Inicial.X;
            double y1 = this.pt1Inicial.Y;
            double x2 = this.pt2Inicial.X;
            double y2 = this.pt2Inicial.Y;

            this.longitud = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            this.angulo = Math.Atan2((y2 - y1), (x2 - x1));

            return this.angulo;
        }

        #endregion

        #endregion
    }
}
