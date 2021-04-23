using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class parameter
    {
        public static int Show(params int[] num)
        {
            int res = 1;
            foreach(var item in num)
            {
                res = res * item;
            }
            return res;
        }
        static void Main(string[] args)
        {
            int x = Show(10, 20, 30, 10);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
