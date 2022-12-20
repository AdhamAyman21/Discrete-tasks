using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Numbers
{
    internal class Program
    {
        static bool IsPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)

                if (num % i == 0)
                    sum = sum + i;
            if (sum == num)
                return true;
            return false;

        }
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("please enter the first number:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number:");
            n2 = int.Parse(Console.ReadLine());


            for (int i = n1; i <= n2; i++)
            {
                if (IsPerfect(i))
                    Console.WriteLine("{0}", i);
            }
        }
    }
}
