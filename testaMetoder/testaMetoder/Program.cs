using System;


namespace testaMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(Compare(EnterNumber(), NumberToCompare()));
        }

        static int EnterNumber()
        {
            Console.WriteLine("Enter a number");
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        static int NumberToCompare()
        {
            Console.WriteLine("What number to compare with?");
            int comparison = int.Parse(Console.ReadLine());
            return comparison;
        }


        static string Compare(int comparison,int input)

        {

            string result = input < comparison ? $"Lower than {comparison}" : input == comparison ? $"Equal to {comparison}" : $"Higher than { comparison}";
            return result;
        }
            
    }
}
