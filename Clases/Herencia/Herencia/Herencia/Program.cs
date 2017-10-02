using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caratula;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Portada portada = new Portada("\tHerencia");

            Persona p = new Persona();
            p.Nombre = "Oscar";
            p.Telefono = 55730016;
            p.Direccion = "Pergoleros 91 C14 101";

            p.ImprimirPersona();

            Alumnos a = new Alumnos(309693185,"7to",9.41);
            a.Nombre = "Mauro";
            a.Direccion = "Donde asaltan y roban";
            a.Telefono = 55788901;

            a.ImprimirPersona();

            Alumnos b = new Alumnos("Pedro", "Lomas de San Anguel", 55730000, 10874591, "10to", 10);
            b.ImprimirPersona();
            b.ImprimirAlumno();


            Console.ReadKey();
            //picturebox
        }
    }
}
