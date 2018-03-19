using System;
using System.Collections.Generic;


namespace Modul_8
{
    class Program
    {
        static void Main(string[] args)
        {

           
            char separator = ',';
            separator = GetSeparator();
            bool errorMessage = GetIfError();

            var eList = new List<int>();
            var fList = new List<int>();
            string[] names;

            while (true)
            {

                while (true)
                {
                    names = EnterNames(separator);
                    eList = new List<int>(CheckIfEmpty(names));
                    fList = new List<int>(CheckNameLenght(names));


                    if (eList.Count != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The list don't contains any names");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    else if (fList.Count != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A person can only have 2 to 9 letters");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    else break;

                }


                var cList = new List<string>(CleanNames(names, fList, eList));
                var nList = new List<string>(AddSuper(cList));
                Print(nList);

                if (TryAgain() == true)
                    continue;
                else break;
            }
        }
        static char GetSeparator()
        {
            Console.WriteLine("Which separator do you want to use? (default is comma)");
            return char.Parse(Console.ReadLine());

        }


       static bool GetIfError()

            
        {
            bool errorMessage=true;
            Console.WriteLine("Do you want to see error message? (default is yes)");
            if (Console.ReadLine() == "no")
                errorMessage = false;

            return errorMessage;
        }
        static string[] EnterNames(char separator)
        {
            Console.WriteLine($"Enter names separated by '{ separator}': ");
            return (Console.ReadLine().Split(separator));

        }

        static bool TryAgain()
        {
            bool tryAgain = true;
            Console.WriteLine("Do you want to do it again? ");

            if (Console.ReadLine()=="no")
               tryAgain=false;

            return tryAgain;
        }
       
        static List<int> CheckIfEmpty(string[] names)
        {
            var emptyList = new List<int>();
            int i = 0;
            foreach (var name in names)
            {
                if (name == "")
                {

                    emptyList.Add(i);
                }
                i++;
            }
            return emptyList;
        }


        static List<int> CheckNameLenght(string[] names)
        {
            int i = 0;
            var falskaNamn = new List<int>();
            foreach (var name in names)
            {

                if (name.Length < 2 || name.Length > 9 && name != "")
                {

                    falskaNamn.Add(i);

                }
                i++;
            }

            return falskaNamn;
        }



        static List<string> CleanNames(string[] names, List<int> fList, List<int> eList)
        {
            int i = 0;
            var cleanNames = new List<string>();
            foreach (string nam in names)
            {
                if (!fList.Contains(i) && !eList.Contains(i))
                {

                    cleanNames.Add(nam.Trim().ToUpper());
                    i++;
                }
            }

            return cleanNames;
        }



        static List<string> AddSuper(List<string> names)
        {
            List<string> superNames = new List<string>();


            foreach (string name in names)
            {

                
                superNames.Add("***SUPER-" + name + "***");
                
            }
            return superNames;

        }



        static void Print(List<string> cleanNames)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string nam in cleanNames)
            {

                Console.WriteLine(nam);

            }
            Console.ForegroundColor = ConsoleColor.Gray;

        }


    }
}
