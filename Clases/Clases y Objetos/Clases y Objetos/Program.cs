using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caratula;

namespace Clases_y_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Portada
            Portada portada = new Portada("    Clases y Arreglos");
            #endregion


            Carga q1 = new Carga(5, 4, 3);
            Carga q2 = new Carga(2, 1, 0);

            
            Console.WriteLine(q1.Mg);

            q1.Px=10;

            Console.WriteLine(q1.Px);



            Console.ReadKey();
        }
    }


    class Carga
    {
        double Magnitud, PosicionX, PosicionY, Angulo, Fuerza, Distancia;

        #region Constructor
        
        public Carga()
        {

        }

        public Carga(double Magnitud, double PosicionX, double PosicionY)
        {
            this.Magnitud = Magnitud;
            this.PosicionX = PosicionX;
            this.PosicionY = PosicionY;
        }

        public Carga(double Magnitud, double PosicionX, double PosicionY, string Prefijo)
        {
            this.Magnitud = Unidades(Magnitud, Prefijo);
            this.PosicionX = Unidades(PosicionX, Prefijo);
            this.PosicionY = Unidades(PosicionY, Prefijo);
        }
        #endregion

        #region Metodos

        public double Mg
        {
            get
            {
                return Magnitud;
            }
        }

        public double Px
        {
            set
            {
                PosicionX = value ;
            }

            get
            {
                return PosicionX;
            }
        }

       

        public double Py()
        {
            return PosicionY;
        }

        public double Dst()
        {
            return 0;
        }

        public double F()
        {
            return Fuerza;
        }

        public void Calc(Carga qn)
        {
            Fuerza = CFuerza(Magnitud,qn.Magnitud);
            
        }

        #endregion



        #region MetodosPrivados
        private double Unidades(double Magnitud, string Prefijo)
        {

            return 0;
        }

        private double CFuerza(double Magnitud1, double Magnitud2)
        {

            return 0;
        }

        #endregion
    }
}




