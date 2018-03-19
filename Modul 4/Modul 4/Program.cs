using System;

namespace Modul_4
{
    class Program
    {
        static void Main(string[] args)
        {

            TypeNameTimes();
            TypeNameTimes2();
            
           
        }

       
        
        private static string TypeNameTimes()

        {
            bool comma = true;
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Times to repeat: ");
            byte times = byte.Parse(Console.ReadLine());
            Console.WriteLine("Type 'Comma' if you want comma-separated output, else enter");
            string wantComma = Console.ReadLine();

            if(wantComma!= "Comma")
             comma = false;



            if (name.Length > 10)
                Console.WriteLine("Too long name");
            else if (name.Length < 3)
                Console.WriteLine("Too short name");
            else if (times > 10)
                Console.WriteLine("Too many times");
            else if (times < 3)
                Console.WriteLine("Too few times");
            else
            {
                int i = 1;
                while (i < times)
                {
                    if (comma==true)
                    Console.WriteLine($"Your name is {name}");
                    
                    else
                        {
                        Console.Write($"Your name is {name},");

                    }

                        i++;
                }
            }

            return name; 
        }

            private static void TypeNameTimes2()

            {
                Console.Write("Enter your name: ");
                string name2 = Console.ReadLine();
                Console.Write("Times to repeat: ");
                byte times2 = byte.Parse(Console.ReadLine());

                int i = 0;
                while (true)
                {
                    Console.WriteLine($"Your name is {name2}");
                    i++;
                    if (i == times2)
                        break;

                }


                }

    }
}
