using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp84
{
    class Program
    {
        static void Main(string[] args)
        {           
            int i, j;
            
            for (i = 1; i <= 11; i++) 
            {
                
                
                for (j = 1; j < 2 * 11; j++) 
                {
                    
                    if (j == (11 - i + 1) 
                        || j == (11 + i - 1)) 
                    {
                        Console.Write("* ");
                    }
                   
                    else if (i == 11 || (i == 11))

                    {

                        Console.Write("* ");
                    }

                   
                    else
                    {
                        Console.Write(" " + " ");
                    }
                }
                Console.Write("\n"); 
                
                // Holy moly what was that...
            }
            Console.ReadLine();
        }
    }
}
