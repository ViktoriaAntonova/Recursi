using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Write number: ");
            int num = int.Parse(Console.ReadLine());  
            if (isEven(num))
            {
                Console.WriteLine($"{num} - even");
            }
            else
            {
                Console.WriteLine($"{num} - odd");
            }
        }

        static bool isEven(int n)
        {
            if (n == 0)
            {
                return true;
            }
            if (n == 1)
            {
                return false;
            }
            return isEven(n - 2);
        }
    }
}
