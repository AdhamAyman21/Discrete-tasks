using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("please enter first num :");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter second num :");
            n2 = int.Parse(Console.ReadLine());
            for (int i = n1; i <= n2; i++)
            {
                if (IsPrime(i))
                    Console.WriteLine("{0}", i);
            }
        }
    }
}
    