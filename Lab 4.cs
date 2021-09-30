using System;

namespace ExponentsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the exponents lab.");

            bool runProgram = true;
            while (runProgram == true)
            {




                //ask for input
                Console.WriteLine("Please enter a number.");
                int num = int.Parse(Console.ReadLine());

                //display table
                Console.WriteLine("Number\tSquared/tCubed");
                Console.WriteLine("=======\t=======\t=======");
                //numbers
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine($"{i}\t{squared(i)}\t{cubed(i)}");
                }

                Console.WriteLine("Would you like to Continue?");
                string choice = Console.ReadLine();
                
                {

                }
                
                {
                    runProgram = false;
                }

            }

        }
        public static int squared(int x)
        {
            int result = x * x;
            return result;
        }

        //Cubed
        public static int cubed(int x)
        {
            int result = x * x * x;
            return result;

        }

    }

}
