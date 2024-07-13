using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void GetSandV(double x, out double s, out double v)
        {
            v = x * x * x;
            s = x * x*6;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double x = Convert.ToDouble(Console.ReadLine());

            double s;
            double v;
            GetSandV(x, out s, out v);

            Console.WriteLine($"Объем куба:{v:f2}\nПлощадь поверхности куба:{s:f2}");

        }
    }
}
    
