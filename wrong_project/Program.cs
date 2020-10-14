using System;

namespace wrong_project
{
    class Program
    {
        static void Main(string[] args)
        {
            DiscManag discManag = new DiscManag();
            Console.WriteLine("*** Purchase value 1000 and loyalty 10 years (5%) ***");

            var result = discManag.Calculate(1000, 2, 10);
            Console.WriteLine($"Customer type 2, 10 years of loyalty, = {result}");

            var result1 = discManag.Calculate(1000, 3, 10);
            Console.WriteLine($"Customer type 3 the value of discount is = {result1}");

            var result2 = discManag.Calculate(1000, 4, 10);
            Console.WriteLine($"Customer type 4 the value of discount is = {result2}\n");

            Console.WriteLine("*** Purchase value 1000 and loyalty 4 years (4%) ***");

            var result3 = discManag.Calculate(1000, 2, 4);
            Console.WriteLine($"Customer type 2, 4 years of loyalty, = {result3}");

            var result4 = discManag.Calculate(1000, 3, 4);
            Console.WriteLine($"Customer type 3 the value of discount is = {result4}");

            var result5 = discManag.Calculate(1000, 4, 4);
            Console.WriteLine($"Customer type 4 the value of discount is = {result5}");
        }
    }
}
