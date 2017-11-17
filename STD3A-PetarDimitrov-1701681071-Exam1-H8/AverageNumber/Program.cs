using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> evenNumbers = new List<int>();
            int result = 1;

            do
            {
                Console.WriteLine("Enter number:");
                int.TryParse(Console.ReadLine(), out result);
                if (result >= 1 && result <= 255)
                {
                    if (result % 2 == 0) evenNumbers.Add(result);
                }

            } while (result != 0);

            if (evenNumbers.Count == 0)
            {
                Console.WriteLine("There aren't even numbers in this diapason [1, 255]");
            }
            else
            {
                Console.WriteLine("Finished !!!");
                Console.WriteLine(new string('*', 20));
                Console.WriteLine("\n");
                int total = 0;
                foreach (int item in evenNumbers)
                {
                    total += item;
                }
                Console.WriteLine("Avarage {0}", total / evenNumbers.Count);
            }
        }
    }
}
