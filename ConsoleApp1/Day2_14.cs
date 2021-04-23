using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Day2_14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            
            int x = 0;
            for (int i =0; i <str.Length; i++)
            {
                if(str[i]=='a' || str[i] =='e' ||str[i]=='i' ||str[i]=='o' || str[i]=='u')
                {
                    x++;
                
                }
                
            }
            Console.WriteLine("Number of vowels in the string=");
            Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
