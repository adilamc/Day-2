using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class swap
    {
        void swapcomp(int a, int b)
        {

            int x = a;
            a = b;
            b = x;
            Console.WriteLine("After swapping");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

        }
        static void Main(string[] args)
        {

            swap Swap = new swap();
            int a =Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before swapping");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Swap.swapcomp(a, b);
            
            Console.ReadLine();


        }
    }
}
