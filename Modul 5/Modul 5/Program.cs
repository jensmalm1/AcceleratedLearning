using System;
using System.Collections.Generic;

namespace Modul_5
{
    class Program
    {
        static void Main(string[] args)
        {

            //ForEach();
            //Surnames();
            //Break();
            IfStatement();


        }

        static void ForEach()
        {

            List<string> names = new List<string>();


            Console.WriteLine("Enter names in a list (like Maria, Peter, Lisa): ");

            string[] namees = Console.ReadLine().Split(',');

            Console.WriteLine("What is your last name?");
            string surname = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var name in namees)
            {
                if (String.IsNullOrWhiteSpace(name))
                    Console.WriteLine("NULLL");
                if (name.Length > 10)
                    Console.WriteLine("Too long name");

                else if (name.Length < 3)
                    Console.WriteLine("Too short name");

                else
                {
                    names.Add(name);

                    Console.WriteLine(name + " " + surname);

                }
            }

        }




            
            static string[] Surnames()
            {
                

                Console.WriteLine("Enter names in a list (like Maria, Peter, Lisa): ");

                string[] namees = Console.ReadLine().Split(',');
                return namees;

            }


        //static void Break(string namees)
        //{
        //    string secretName = "Zelda";
        //    Console.WriteLine("What is your last name?");
        //    string surname = Console.ReadLine();

        //    Console.ForegroundColor = ConsoleColor.Green;

        //    bool allow = false;

        //    foreach (var name in namees)
        //    {


        //        if (name.Contains("AllowZelda"))
        //        {

        //          allow = true;
        //            continue;
        //        }
               
                

        //        if (name == secretName && allow==false)

        //            break;
               

        //        else if (String.IsNullOrWhiteSpace(name))
        //            Console.WriteLine("NULLL");
        //        else if (name.Length > 10)
        //            Console.WriteLine("Too long name");

        //        else if (name.Length < 3)
        //            Console.WriteLine("Too short name");

        //        else
        //        {

        //            Console.WriteLine(name + " " + surname);

        //        }

        //    }

        //}


        static void IfStatement()
        {
            Console.WriteLine("Enter a number");
            int input = int.Parse(Console.ReadLine());
            if (input < 20)
                Console.WriteLine("Lower than 20");
            else if (input == 20)
                Console.WriteLine("Equal to 20");

            else
                Console.WriteLine("Higher than 20");
                

        }
    }
}
