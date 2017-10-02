using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Exepcion_Forms.Exceptions;

namespace Exepcion_Forms
{
    class Plot
    {
        #region Variables Globales
        Bitmap papel;
        
        #endregion

        #region Constructores
        public Plot()
        {
            this.papel = new Bitmap(2000, 2000);
            DrawNull();
        }

        public Plot(double[] x, double[] y)
        {
                      
            if (x.Length != y.Length)
            {
                //throw new System.ArgumentException();
                //throw new Exceptions.MatrixException("Error de dimension");
                throw new MatrixException("Error de dimension");
                
            }
            else
            {
                  papel = new Bitmap(2000, 2000);
                  DrawNull();
                    
            }
                
            
        }


        #endregion

        #region Accesos
        public Bitmap bitmap
        {
            get
            {
                return this.papel;
            }     
        }
        #endregion

        #region Metodos Publicos

        #endregion

        #region Metodos Privados
        private void DrawNull()
        {
            Graphics fromGraphics = Graphics.FromImage(papel);

            //Dibuja el Eje Y
            PointF ejeYi = new PointF(papel.Width / 2, papel.Height);
            PointF ejeYf = new PointF(papel.Width / 2, 0);
            fromGraphics.DrawLine(new Pen(Color.Red), ejeYi, ejeYf);
            //Dibuja el Eje X
            PointF ejeXi = new PointF(0,papel.Height / 2);
            PointF ejeXf = new PointF(papel.Width, papel.Height / 2);
            fromGraphics.DrawLine(new Pen(Color.Red), ejeXi, ejeXf);
        }
        #endregion

    }
}
