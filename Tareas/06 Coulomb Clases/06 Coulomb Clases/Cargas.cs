using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColumbSwitch;

namespace _06_Coulomb_Clases
{
    class Cargas : Metodos 
    {

        #region Varaibles Globales
        private double magnitud;
        private double[] pos = new double[3];
        private double fuerza;
        private const double K = 9e9;

        #endregion

        #region Instancias Creadas

        //Se instancia un objeto de control para poder ser utilizado 
        Control control = new Control();
        Prefijo prefijo = new Prefijo();

        #endregion
        
        #region Constructores de Clase

        /// <summary>
        /// Creates a new charge in (X,Y)
        /// </summary>
        /// <param name="magnitud"></param>
        /// <param name="posX"></param>
        /// <param name="posY"></param>
        public Cargas(double mag, double posX, double posY, double posZ)
        {
            magnitud = mag;
            pos[0] = posX;
            pos[1] = posY;
            pos[2] = posZ;

        }
        /// <summary>
        /// Crea una carga donde el usuario introduce por los valores de magnitud y posicion en el espacio
        /// </summary>
        /// <param name="x">No. de Carga</param>
        public Cargas(string x)
        {
            Console.WriteLine("Introduce el Valor de la carga q" + x);
            magnitud = control.validaDato();
            prefijo.mostrarC();
            magnitud = prefijo.prefijosC(control.validaDato(),magnitud);
            Console.WriteLine("q"+x+" = "+ magnitud + " [C]");

            Console.WriteLine("Introduce su componente X" + x + "= ");
            pos[0] = control.validaDato();
            prefijo.mostrarM();
            pos[0] = prefijo.prefijosM(control.validaDato(), pos[0]);
            Console.WriteLine("X" + x + " = " + pos[0] + " [m]");

            Console.WriteLine("Introduce su componente Y" + x + "= ");
            pos[1] = control.validaDato();
            prefijo.mostrarM();
            pos[1] = prefijo.prefijosM(control.validaDato(), pos[1]);
            Console.WriteLine("Y" + x + " = " + pos[1] + " [m]");

            //Console.WriteLine("Introduce su componente Z" + x + "= ");
            //pos[2] = control.validaDato();
            //prefijo.mostrarM();
            //pos[2] = prefijo.prefijosM(control.validaDato(), pos[2]);
            //Console.WriteLine("Z" + x + " = " + pos[2] + " [m]");
        }

        #endregion
        
        #region Metodos y Funciones Publicas

        #region Metodos Get
        public double[] darPosicion
        {
            get
            {
                return pos;
            }
        }

        public double darMagnitud
        {

            get
            {
                return magnitud;
            }
        }
        #endregion

        #region Funciones 
        
        /// <summary>
        /// Encuentra el Vector que une a los Cargas en el espacio
        /// </summary>
        /// <param name="qX"></param>
        /// <param name="qY"></param>
        /// <returns></returns>
        public double[] VecPos(Cargas qX, Cargas qY)
        {
            double[] r = new double[qX.pos.Length];
            for (int i = 0; i < pos.Length; i++)
            {
                r[i] = qX.pos[i] - qY.pos[i];
            }

            return r;
        }

        /// <summary>
        /// Crea un Vector unitario en la direccion de la fuerza      
        /// </summary>
        /// <param name="qX"></param>
        /// <param name="qY"></param>
        /// <returns>Devuelve un direccion fuerza qX con respecto a qY</returns>
        public double[] DirFuerzaXY(Cargas qX, Cargas qY)
        {
            double[] dirFuerza = new double[qX.pos.Length];
            if (qX.darMagnitud * qY.darMagnitud > 0)
            {
                dirFuerza = VecPos(qX, qY);
            }
            else
            {
                dirFuerza = VecPos(qX, qY);
                for (int i = 0; i < dirFuerza.Length; i++)
                {
                    dirFuerza[i] = -dirFuerza[i];
                }

            }


            return Unitario(dirFuerza);
        }



        /// <summary>
        /// Calcula la magnitud de la Fuerza entre dos Cargas estaticas
        /// </summary>
        /// <param name="qX"></param>
        /// <param name="qY"></param>
        /// <returns></returns>
        public double darMagFuerza(Cargas qX, Cargas qY)
        {
            fuerza = K * Math.Abs(qX.darMagnitud * qY.darMagnitud)/(Math.Pow(Norma(VecPos(qX,qY)),2)); 
            return fuerza; 
        }

        /// <summary>
        /// Devuelve el valor el Vector Fuerza entre dos Cargas
        /// </summary>
        /// <param name="qX"></param>
        /// <param name="qY"></param>
        /// <returns></returns>
        public double[] FuerzaXY(Cargas qX, Cargas qY)
        {
            double[] VecFuerza = new double[qX.darPosicion.Length];

            darMagFuerza(qX,qY);

            for (int i = 0; i < VecFuerza.Length; i++)
            {
                VecFuerza[i] = fuerza * DirFuerzaXY(qX, qY)[i];
            }
            return VecFuerza;
        }

        

        #endregion


        
        #endregion




    }
}
