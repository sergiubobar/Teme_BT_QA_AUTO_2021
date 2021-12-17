using System;

namespace Teme_BT_QA_AUTO_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise01(args);
            Exercise02();
            Exercise03(12345);
            Exercise04(12);
        }

        // This function will implement an arithmetic calculator that takes 3 arguments: the first number, the operation, the second number.
        static void Exercise01(string[] args)
        {
            if (args.Length == 3)
            {
                float a = float.Parse(args[0]);
                float b = float.Parse(args[2]);
                string op = args[1];
                float result = 0;

                switch (op)
                {
                    case "+":
                        {
                            result = a + b;
                            break;
                        }
                    case "-":
                        {
                            result = a - b;
                            break;
                        }
                    case "*":
                        {
                            result = a * b;
                            break;
                        }
                    case "/":
                        {
                            result = a / b;
                            break;
                        }
                    case "%":
                        {
                            result = a % b;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Not a valid operator!");
                            break;
                        }
                }
                Console.WriteLine("Result is: " + result);
            }
            else
            {
                Console.WriteLine("3 args are needed!");
            }

        }

        // This function will calculate the sum of the first 100 numbers higher than 0
        static void Exercise02()
        {
            int num = 100, sum = 0;

            for (int i = 1; i <= num; ++i)
            {
                sum += i;
            }
            Console.WriteLine("The sum of the first 100 numbers higher than 0 is: {0}", sum);
        }


        // This function will check if a number is palindrome ( e.g. palindrome 1221, 34143)
        static void Exercise03(int numar)
        {
            int remainder, suma = 0, temp;
            temp = numar;

            while (numar > 0)
            {
                remainder = numar % 10;
                suma = (suma * 10) + remainder;
                numar = numar / 10;
            }

            if (temp == suma)
            {
                Console.WriteLine("The chosen number is a palindrome!");
            }
            else
            {
                Console.WriteLine("The chosen number is not a palindrome!");
            }
        }

        
        // This function will display all the prime numbers lower than a given number
        static void Exercise04(int numar)
        {
            Console.WriteLine("The prime numbers lower than {0} are:", numar);
            for (int i = 2; i <= numar; i++)
            {
                if (isPrime(i))
                    Console.Write(i + " ");
            }
        }
        static bool isPrime(int numar)
        {
            // Corner case
            if (numar <= 1)
                return false;

            // Verifica de la  2 la n-1
            for (int i = 2; i < numar; i++)
                if (numar % i == 0)
                    return false;

            return true;
        }
    }
}
