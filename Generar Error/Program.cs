using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generar_error
{
    class Program
    {
        static void Main(string[] args)
        {
            Int n, a, r;
            Console.WriteLine("Dijite el numero de lados: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dijite el apotema: ");
            a = int.Parse(Console.ReadLine());
            r = n * a / 2;
            Console.WriteLine("El resultados es: " + r);
            Console.ReadLine();
        }
    }
}
