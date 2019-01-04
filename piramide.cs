using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please choose a num from 1-10");
            int size = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= size; i++)
                
            {
               /* for (int l = 1; l <= i; l++)
                {

                    Console.Write(l);
                }
                for (int l = i + 1; l <= size; l++)
                {
                    Console.Write("*");
                }
                */
                for(int j = 1; j<=size; j++)
                {
                    
                    if(j<=i)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write("*");
                    }

                    
                }
            }
        }
    }
}
