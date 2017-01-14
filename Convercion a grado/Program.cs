using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convecior_de_grados
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double r;
            Console.WriteLine("Dijete los grados celcius: ");
            n = int.Parse(Console.ReadLine());
            r = n - 32 / 18;
            Console.WriteLine("El resultados es: " + r);
            Console.ReadLine();
        }
    }
}
