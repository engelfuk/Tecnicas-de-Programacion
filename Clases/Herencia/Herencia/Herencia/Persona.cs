using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Persona
    {
        #region Variables Globales

        private string _Nombre;
        private string _Direccion;
        private double _Telefono;


        #endregion

        #region Constructores



        public Persona()
        {

        }

        public Persona(string nombre, string direccion, double telefono)
        {
            this._Nombre = nombre;
            this._Direccion = direccion;
            this._Telefono = telefono;

        }

        #endregion

        #region Acceso

        public string Nombre
        {
            get
            {
                return this._Nombre;
            }

            set
            {
                this._Nombre = value;

            }
        }

        public string Direccion
        {
            get
            {
                return this._Direccion;
            }

            set
            {
                this._Direccion = value;

            }
        }

        public double Telefono
        {
            get
            {
                return this._Telefono;
            }

            set
            {
                this._Telefono = value;
            }
        }

        #endregion

        public void ImprimirPersona()
        {
            Console.WriteLine("Nombre: "+_Nombre);
            Console.WriteLine("Direccion: " + _Direccion);
            Console.WriteLine("Telefono: "+_Telefono);
        }

    }
}
