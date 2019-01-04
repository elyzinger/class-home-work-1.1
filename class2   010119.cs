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
            Random student = new Random();

            int class100, class30, class10,left;
            int x = student.Next(1, 500);
            do
            {
                

                class100 = (x / 100)*100;
                class30 = ((x - class100) / 30)*30;
                class10 = ((x - class100 - class30) / 10)*10;
                left = x - class100 - class30 - class10;
                Console.WriteLine($"{class100} student for big class");
                Console.WriteLine($"{class30} student for meidum class");
                Console.WriteLine($"{class10} student for small class");

            }
            while (left < 0);

                Console.WriteLine($"{left} left with no class");
            
          
        }
    }
}
