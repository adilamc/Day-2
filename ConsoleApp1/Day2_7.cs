using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Author
    {
        public String name1;
        public int rank1;
    }
    class class5
    {
        public String name2;
        public int rank2;
        static void Main(string[] args)
        {
            class5 Class5 = new class5();
            Author author = new Author();
            bool result;
            result = author is Author;
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
