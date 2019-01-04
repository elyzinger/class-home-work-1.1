using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_1._1._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();

            for (int i = 1; i < 100; i++)
            {

                int y = 2;
                int x = num.Next(1, 100);
                while (x % y != 0 && y <= x)
                    y++;
                if (y < x || x == 1)
                {
                    continue;
                }
                else
                    
                Console.WriteLine(x);
                break;
            }
          
        }
    }
}
