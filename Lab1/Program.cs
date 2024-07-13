using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static double GetS(double x, double y, double z)
        {

            double p = (x + y + z) / 2;
            double s = Math.Sqrt(p*(p-x)*(p-y)*(p-z));
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого труегольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длины сторон второго труегольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());

            if (GetS(x1, y1, z1) > GetS(x2, y2, z2))
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else if (GetS(x1, y1, z1) < GetS(x2, y2, z2))
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else
            {
                Console.WriteLine("Площадь треугольников равны");
            }
        }
    }
}
