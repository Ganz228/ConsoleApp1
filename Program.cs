using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammPosl
{
    
    class Program
    {
        private static double x;
        private static double y;

        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x = ");
            double x = Convert. ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y = ");
            double y = Convert.ToDouble(Console.ReadLine());


            double a = (14 * Math.Sin(x) + Math.Pow(y, 2)) / (Math.Pow(Math.Cos(x), 3));
            
            Console.WriteLine(a);



        }
    }
}

