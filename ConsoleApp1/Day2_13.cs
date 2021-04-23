using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Day2_13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            char [] str2 = new char[str.Length];
            
            for (int i = str.Length-1; i >= 0 ; i--)
            {
                str2[i]= str[i];
            }
            string revstr = new string(str2);
            if(revstr == str)
            {
                Console.WriteLine("It is palindrome");
            }
            else
            {
                Console.WriteLine("Please re-enter the string");
            }
            
            Console.ReadLine();
        }
    }
}
