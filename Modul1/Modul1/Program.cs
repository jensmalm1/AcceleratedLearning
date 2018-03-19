using System;
using System.Collections.Generic;
using System.Text;


namespace Modul1
{
    class Program
    {

        static void Main(string[] args)
        {

            //WhatsYourName();
            //Retirement();
            StringCreation();


        }
        static void WhatsYourName()
        {

            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("How old are you? ");
            string age = Console.ReadLine();
            Console.Write("What is your favorite letter? ");
            string letter = Console.ReadLine();
            Console.Write("Where are you from? ");
            string where = Console.ReadLine();
            Console.Write("What is your favorite color? ");
            string color = Console.ReadLine();


            Console.WriteLine("\nThank you!");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n Your name is: {0}\n You are {1} years old \n Your favorite letter is {2} \n You are from {3} \n Your favorite color is: {4}\n", name, age, letter, where, color);


            Console.ForegroundColor = ConsoleColor.Gray;

             

        }
        static void Retirement()
        {

            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.Write("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());

            int toPension = 65 - age;
            Console.Write("What is your favorite character? ");
           string chara = Console.ReadLine();

          
            Console.Write("Where are you from? ");
            string where = Console.ReadLine();
            Console.Write("What is your favorite color? ");
            string color = Console.ReadLine();




            Console.WriteLine("\nThank you!");

            Console.ForegroundColor = ConsoleColor.Green;

            if (int.TryParse(chara, out int n) )
                Console.WriteLine("\n Your name is: {0}\n You have {1} years until retirement \n You like numbers \n You are from {3} \n Your favorite color is: {4}\n", name, toPension, chara, where, color);


            else Console.WriteLine("\n Your name is: {0}\n You have {1} years until retirement \n You don't like numbers \n You are from {3} \n Your favorite color is: {4}\n", name, toPension, chara, where, color);


            Console.ForegroundColor = ConsoleColor.Gray;

        }

        static void StringCreation()
        {

            Console.Write("Enter Fruit 1: ");
            string fruitOne = Console.ReadLine();
            Console.Write("Enter Fruit 2: ");
            string fruitTwo = Console.ReadLine();
            Console.Write("Enter Fruit 3: ");
            string fruitThree = Console.ReadLine();
            string text = $"You entered three fruits: {fruitOne}, {fruitTwo}, {fruitThree}!";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nYou entered three fruits: "+fruitOne+", "+fruitTwo+", "+fruitThree+"!");
            Console.WriteLine("You entered three fruits: {0}, {1}, {2}! ",fruitOne, fruitTwo, fruitThree);
            Console.WriteLine(text+"\n");

            Console.ForegroundColor = ConsoleColor.Gray;


            Console.WriteLine("How many fruits do you want?");
            int number = Convert.ToInt32(Console.ReadLine());


            List<string> fruits = new List<string>();
            


            for (int i = 0; i < number; i++)
            {

                Console.WriteLine("Enter Fruit "+(i+1)+": ");

                fruits.Add(Console.ReadLine());

                    }
            foreach (string frukt in fruits)
                Console.WriteLine(frukt);

            StringBuilder MyStringBuilder = new StringBuilder();

            foreach (string frukt in fruits)

            {
                MyStringBuilder.Append(frukt);
                    }


        }
    }
}
