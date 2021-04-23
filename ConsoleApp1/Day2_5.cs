using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class swap
    {
        void swapcomp(out int a)
        {

     
            Console.WriteLine("Inside function");
            a = 6;

        }
        static void Main(string[] args)
        {

            swap Swap = new swap();
            int a=5;
            Console.WriteLine("a=" + a);
            Swap.swapcomp(out a);
            Console.WriteLine("Inside main function");
            Console.WriteLine("a=" + a);
            
            Console.ReadLine();


        }
    }
}
