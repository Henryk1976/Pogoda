using System;

namespace Pogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperaturę:");

            string x = Console.ReadLine();

            int ax = int.Parse(x);

            if (ax < 0) 
            {
                Console.WriteLine("cholernie piździ");
            
            }
            if (ax > 0 && ax < 10) 
            {
                Console.WriteLine("zimno");

            
            }
            if (ax >= 10 && ax < 20 ) 
            {
                Console.WriteLine("chłodno");

            }
            if(ax >= 20 && ax < 30 ) 
            {
                Console.WriteLine("w sam raz");

            }
            if ( ax >= 30 && ax < 40) 
            {
                Console.WriteLine("zaczyna być słabo , bo gorąco");

            }
            if (ax >= 40) 
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę");
            }

        }
    }
}
