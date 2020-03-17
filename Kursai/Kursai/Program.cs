using System;

namespace Kursai
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int test = Max(3, 6, 9);
            Console.WriteLine("Bigest number: " + test);
            bool test2 = IsInRange(50, 20, 70);
            Console.WriteLine(test2);


            Console.ReadKey();

            
        }
        static bool IsInRange(int testNumber, int min, int max)
        {
            if (testNumber>=min && testNumber <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
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
