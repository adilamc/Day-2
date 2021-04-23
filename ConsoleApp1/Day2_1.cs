using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Day2_1
    {
        void checkOddEven(int a)
        {
            
            if (a%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        static void Main(string[] args)
        {

            Day2_1 day2_1 = new Day2_1();
            day2_1.checkOddEven(5);
            Console.ReadLine();
            

        }
       
    }
}
