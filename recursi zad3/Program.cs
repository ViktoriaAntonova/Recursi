using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursi_zad3
{
    internal class Program
    {
        static int Reverse(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return (number % 10) * (int)Math.Pow(10, (int)Math.Log10(number)) + Reverse(number / 10);
            }
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int reversed = Reverse(number);
            Console.WriteLine(reversed);
        }
    }
}
