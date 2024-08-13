using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true) {
                Console.WriteLine("input first value");
                double A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("input second value");
                double B = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("input third value");
                double C = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("input forth value");
                double D = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("input fifth value");
                double T = Convert.ToInt32(Console.ReadLine());
                
                string p = (Console.ReadLine());


            double Z = (Math.Sqrt((A * B) / (2 * D))*3 - Math.Sqrt(Math.Sqrt((T * C)) / (2 * D)) *4) / (4 * A * C);  

            Console.WriteLine("the equation is :" + Z);
            Console.ReadLine();
            }
            

            

        }
    }
}
