using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Portada fromPortada = new Portada("Colecciones");

            ArrayList dato = new ArrayList();
            dato.Add(5);
            dato.Add(27.0);
            dato.Add(33);
            dato.Add(40);
            dato.Add(58);
            dato.Remove(27.0);
            dato.RemoveAt(dato.Count-1);


            dato.Insert(1, 53);
            dato.Insert(dato.Count - 1, 53);


            Console.ReadKey();
        }
    }
}
