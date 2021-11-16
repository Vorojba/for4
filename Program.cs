using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            double c,a=1,b=10;
            Console.Write("Введите число:");
            c = Convert.ToDouble(Console.ReadLine());
            double i;
            for (i=1;i<=b;i++)
            {
                Console.WriteLine($"{c}*{i}=" + (c * i));
            }
            Console.ReadKey();
        }
    }
}
