using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Alumnos : Persona
    {
        #region Variables Globales
        private double _NoCuenta;
        private string _Semestre;
        private double _Promedio;


        #endregion

        #region Constructores

        public Alumnos(double noCuenta, string semestre, double promedio)
        {
            this._NoCuenta = noCuenta;
            this._Semestre = semestre;
            this._Promedio = promedio;
            
        }

        public Alumnos(string nombre, string direccion, double telefono, double noCuenta, string semestre, double promedio)
            : base(nombre,direccion,telefono)
        {
            


            //Nombre = nombre;
            //Direccion = direccion;
            //Telefono = telefono;
            this._NoCuenta = noCuenta;
            this._Semestre = semestre;
            this._Promedio = promedio;

        }

        #endregion

        #region Accesos

        public double NoCuenta
        {
            get
            {
                return this._NoCuenta;
            }

            set
            {
                this._NoCuenta = value;

            }
        }

        public double Promedio
        {
            get
            {
                return this._Promedio;
            }

            set
            {
                this._Promedio = value;

            }
        }

        public string Semestre
        {
            get
            {
                return this._Semestre;
            }

            set
            {
                this._Semestre = value;

            }
        }

        #endregion

        public void ImprimirAlumno()
        {
            ImprimirPersona();
            Console.WriteLine("NoCuenta: " + _NoCuenta);
            Console.WriteLine("Promedio: " + _Promedio);
            Console.WriteLine("Semestre: " + _Semestre);
        }


    }
}
