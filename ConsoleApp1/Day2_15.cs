using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Day2_15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            int x = 0;
            int max = -1;
            int[] charCount = new int[256];
            int length = str.Length;
            string[][] counterarray = new string[str.Length][];
            for (int i = 0; i < str.Length; i++)
            {
                charCount[str[i]]++;

            }
            char character = ' ';
            for(int i=0; i<length;i++)
            {
                if(max<charCount[str[i]])
                {
                    max = charCount[str[i]];
                    character = str[i];
                }
                
            }
            Console.WriteLine("The string is {0}", str);
            Console.WriteLine("Max occuring char in the string" + character + "and count is" + max);

            Console.ReadLine();
        }
        
    }
}
