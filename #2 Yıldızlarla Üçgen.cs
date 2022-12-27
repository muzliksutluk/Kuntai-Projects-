using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp82
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; i < j; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        
    }
}
