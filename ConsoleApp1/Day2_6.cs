using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class conversion
    {
        
        static void Main(string[] args)
        {
            //string b = 1.ToString();
            //string b = Convert.ToString(null);
            //int number = int.Parse("1254 ");
            int result;
            int.TryParse("123554", out result);
            if(result==0)
            {
                Console.WriteLine(result +"not a number");
            }
            else 
            {
                Console.WriteLine(result + "is a number");
            }
            //Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
