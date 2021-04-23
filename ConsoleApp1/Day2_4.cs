using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class swap
    {
        void swapcomp(ref int a,ref  int b)
        {

            int x = a;
            a = b;
            b = x;
            Console.WriteLine("Inside function");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

        }
        static void Main(string[] args)
        {

            swap Swap = new swap();
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inside main function");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Swap.swapcomp(ref a,ref b);

            Console.ReadLine();


        }
    }
}
