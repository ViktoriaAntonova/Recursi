using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static int Power(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            return a * Power(a, b - 1);
        }

        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = Power(a, b);
            Console.WriteLine($"{a} ^ {b} = {result}");
        }
    }
}
