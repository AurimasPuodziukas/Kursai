using System;

namespace Kursai
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int test = Max(3, 6, 9);
            Console.WriteLine(test);


            Console.ReadKey();

            
        }

        static int Max(int number1, int number2, int number3)
        {
            if (number1 > number2 && number1 > number3)
            {
                return number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                return number2;
            }
            else
            {
                return number3;
            }
        }
    }
}
