using System;

namespace Modul6
{
    class Program
    {
        static void Main(string[] args)

        {


            //IfStatement();
            //GuessingGame();
            ConditionalOperator();



        }

        static void IfStatement()
        {
            Console.WriteLine("Enter a number");
            int input = int.Parse(Console.ReadLine());


            Console.WriteLine("What number to compare with?");
            int comparison = int.Parse(Console.ReadLine());



            if (input < comparison)
                Console.WriteLine($"Lower than {comparison}");
            else if (input == comparison)
                Console.WriteLine($"Equal to {comparison}");

            else
                Console.WriteLine($"Higher than {comparison}");

        }

        static void GuessingGame()
        {
            Random randNr = new Random();
            int randNumber = randNr.Next(1, 100);


            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("Guess nr +", i);


                if (int.Parse(Console.ReadLine()) == randNumber)
                {
                    Console.WriteLine("Correct!!");
                    break;
                }
                Console.WriteLine("Try again");

            }

        }


            static void ConditionalOperator()
            {
            Console.WriteLine("Enter a number");
            int input = int.Parse(Console.ReadLine());


            Console.WriteLine("What number to compare with?");
                int comparison = int.Parse(Console.ReadLine());



                string result = input < comparison ? $"Lower than {comparison}" : input == comparison ? $"Equal to {comparison}" : $"Higher than { comparison}";
                Console.WriteLine(result);
            }       
        
    }
}
