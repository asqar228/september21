using System;

namespace Program
{
    public class Program
    {
        static void Main()
        {
            //C1.21
            //DisplayNumbers();

            //C2.6
            //Console.WriteLine(Exponentiation());

            //C5.13
            Random random = new Random();
            int newNum = random.Next(1000000);
            Console.WriteLine(newNum);
            AddingNumbers(newNum);

            int rand = random.Next(17);
            //Console.WriteLine(rand);
            //Console.WriteLine(Squaring(rand));


        }

        static void AddingNumbers(int number)
        {
            int divisor = 10;
            int container = 0;
            int mediator = 0;
            for(int i = 0; i < number.ToString().Length; i++)
            {
                mediator = number % divisor;
                divisor /= 10;
                container += mediator / divisor;
                divisor *= 100;
            }
            Console.WriteLine(container);
        }

        static int Squaring(int labRat)
        {
            //int starter = 1;
            int container = 1;
            int result = 0;
            for(int i = 0; i < labRat; i++)
            {
                result += container;
                container = container + 2;
            }
            return result;
        }

        static double Exponentiation()
        {
            double result = 1;
            double mediator = 1 / 3.0;
            for(int i = 0; i < 7; i++)
            {
                result = result + mediator;
                mediator /= 3.0;
            }
            return result;
        }
        
        static void DisplayNumbers()
        {
            for (int i = 2; i < 7; i += 2)
            {

                for (int j = 2; j < 7; j += 2)
                {
                    Console.WriteLine(i + ", " + j);
                }
            }
        }
    }
}