using System;

namespace ConsoleApplication1
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Table of Fahr and Cels temp:");
            Console.WriteLine("Fahr    Cels");
            double fahr, cels;
            const double upper = 300;
            const int lower = 0;
            var step = 20;
            fahr = lower;
            while (fahr <= upper)
            {
                cels = (5.0/9.0)*(fahr - 32.0);
              
                Console.WriteLine("{0:f} {1:f} ", fahr, cels);
                fahr = fahr + step;
                }
        

        Console.Write("Press any");
           Console.Read();
        }
    }
}
