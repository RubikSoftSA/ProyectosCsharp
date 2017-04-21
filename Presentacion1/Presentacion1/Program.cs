using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            decimal x   = 32.5m;
            float f     = 450.4f;
            double d    = 48.5d;
            string sa = "hola mundo";
            bool bandera = false;
            DateTime fecha = DateTime.MinValue;

            Console.WriteLine("El valor de i es:{0}", i);
            Console.WriteLine("El valor de i es:{0:C}", 0);
            Console.WriteLine("El valor de fecha es: " +fecha.ToShortDateString());
            Console.ReadKey();
        }
    }
}
