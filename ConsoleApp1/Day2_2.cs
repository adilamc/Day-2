using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class swap
    {
        void swapcomp(int a,int b)
        {

            int x = a;
            a = b;
            b = x;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
        static void Main(string[] args)
        {

            swap Swap = new swap();
            int a = 5, b = 6;
            Swap.swapcomp(a,b);
            Console.WriteLine("After swapping");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadLine();


        }
    }
}
