using System;

namespace question04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the reverse timestables (highest number first) for:");
            var number = Console.ReadLine();

            var number1 = 0; 
            var isNumber = int.TryParse(number, out number1); 

            for(var i = 11; i >= 0; i--) {
                var a = i + 1;
                Console.WriteLine($"{a} x {number} = {a * number1}");
            }
        }
    }
}
