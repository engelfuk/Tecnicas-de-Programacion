
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
        private List<PointF> pos1;
        private List<PointF> pos2;
        private Pen pluma;

        private double angulo;
        private double longitud;

        #endregion

        #region Constructores
        /// <summary>
        /// Construye un Eslabon en base a dos puntos en el plano
        /// </summary>
        /// <param name="pt1">Punto 1</param>
        /// <param name="pt2">Punto 2</param>
        public Eslabon(PointF pt1, PointF pt2, Pen pluma)
        {
            this.pluma = pluma;
            this.pos1 = new List<PointF>();
            this.pos2 = new List<PointF>();
            this.pt1Inicial = pt1;
            this.pt2Inicial = pt2;

            pos1.Add(pt1);
            pos2.Add(pt2);
            CalculaLongitud();

        }

        public Eslabon()
        {

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


        public double GetLongitud
        {
            get
            {
                this.longitud = CalculaLongitud();
                return this.longitud;
            }
        }

        //public Bitmap GetBitMap
        //{
        //    get { return this.myBitmap; }
        //}


        #endregion

        #region Metodos

        #region Publicos

        public Bitmap MergeBitMaps(Bitmap img1, Bitmap img2, Bitmap img3)
        {
            Bitmap img = new Bitmap(img1.Width, img1.Height);
            Graphics fromGraphics = Graphics.FromImage(img);

            fromGraphics.DrawImage(img1, 0, 0);
            fromGraphics.DrawImage(img2, 0, 0);
            fromGraphics.DrawImage(img3, 0, 0);



            return img;

        }

        public Bitmap DibujaBrazo(Eslabon eslabon1, Eslabon eslabon2, Eslabon eslabon3)
        {
            return MergeBitMaps(eslabon1.DibujaEslabon(), eslabon2.DibujaEslabon(), eslabon3.DibujaEslabon());
        }



        public Bitmap DibujaEslabon()
        {
            Bitmap myBitmap = new Bitmap(800, 800);
            Graphics fromGraphics = Graphics.FromImage(myBitmap);

            fromGraphics.TranslateTransform(myBitmap.Width / 2, myBitmap.Height / 2);
            fromGraphics.ScaleTransform(1, -1);
            fromGraphics.DrawLine(pluma, pos1.Last(), pos2.Last());
            fromGraphics.DrawLine(new Pen(Color.White, pluma.Width / 2), pos1.Last(), pos2.Last());
            fromGraphics.FillEllipse(new SolidBrush(Color.Gray), pos1.Last().X - pluma.Width, pos1.Last().Y - pluma.Width, (2 * pluma.Width), (2 * pluma.Width));
            fromGraphics.FillEllipse(new SolidBrush(Color.Gray), pos2.Last().X - pluma.Width, pos2.Last().Y - pluma.Width, (2 * pluma.Width), (2 * pluma.Width));

            return myBitmap;
        }



        public void RotEslabon1(double th1)
        {

            th1 *= Math.PI / 180;

            pos1.Add(new PointF(0, 0));


            PointF pt = new PointF(
                (float)(longitud * Math.Cos(th1)),
                (float)(longitud * Math.Sin(th1)));

            pos2.Add(pt);

        }

        public void RotEslabon2(double th1, double th2, Eslabon eslabonAnterior)
        {

            pos1.Add(eslabonAnterior.GetListaPos2.Last());

            th1 *= Math.PI / 180;
            th2 *= Math.PI / 180;


            PointF pt = new PointF(
                (float)(eslabonAnterior.GetLongitud * Math.Cos(th1) + longitud * Math.Cos(th1 + th2)),
                (float)(eslabonAnterior.GetLongitud * Math.Sin(th1) + longitud * Math.Sin(th1 + th2)));

            pos2.Add(pt);


        }

        public void RotEslabon3(double th1, double th2, double th3, Eslabon eslabonAnterior, Eslabon eslabonAnteAnterior)
        {

            pos1.Add(eslabonAnterior.GetListaPos2.Last());

            th1 *= Math.PI / 180;
            th2 *= Math.PI / 180;
            th3 *= Math.PI / 180;

            PointF pt = new PointF(
                (float)(eslabonAnteAnterior.GetLongitud * Math.Cos(th1) + eslabonAnterior.GetLongitud * Math.Cos(th1 + th2) + longitud * Math.Cos(th1 + th2 - th3)),
                (float)(eslabonAnteAnterior.GetLongitud * Math.Sin(th1) + eslabonAnterior.GetLongitud * Math.Sin(th1 + th2) + longitud * Math.Sin(th1 + th2 - th3)));

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
