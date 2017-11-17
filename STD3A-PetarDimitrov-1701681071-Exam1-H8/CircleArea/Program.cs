using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int radius = random.Next(33, 187);
            Console.WriteLine($"The circle random radius is = {radius}");
            Console.WriteLine($"The circle area is = {(double)(Math.PI * radius * radius):f2}");
        }
    }
}
