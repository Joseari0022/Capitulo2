using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grado_Radianes
{
    class Program
    {
        static void Main(string[] args)
        {
            int g, r;
            Console.WriteLine("Dijite los grados: ");
            g = int.Parse(Console.ReadLine());
            r = g * muo / 180;
            Console.WriteLine("El resultados es: " + r);
            Console.ReadLine();
        }
    }
}}
