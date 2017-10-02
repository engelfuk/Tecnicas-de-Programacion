using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbSwitch
{
    class Cargas
    {
        Prefijo Q1 = new Prefijo();

        public double Carg(string carga)
        {
            
            Console.Write("Porfavor introducta el valor de la carga " + carga + " \n" + carga + " = ");
            
            double q1 = Q1.validaDato(); // Evita que el usuario ingrese opciones invalidas
            Q1.mostrarC(); // Muestra al usuario los prefijos disponibles
            q1 = Q1.prefijosC(Q1.validaDato(), q1); //La carga toma el valor en las unidades SI
            Console.WriteLine(carga + " = " + q1 + "[C]");
            Console.WriteLine("\n\n\n\n\n\n\n");

            return q1;
        }

        
    }
}
