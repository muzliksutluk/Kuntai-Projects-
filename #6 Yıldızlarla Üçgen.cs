using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87
{
    class Program
    {
        static void Main(string[] args)
        {         
            for (int i = 0; i < 7; i++)
            {
                for (int k = i; k < 7; k++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x <= i; x++)
                {
                    Console.Write("*");
                    Console.Write(""); 
                }
                Console.WriteLine();
            }
            Console.Read();                  
        }
    }
}
// The end...