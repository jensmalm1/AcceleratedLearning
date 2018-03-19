using System;

namespace MethodsIn3._3
{
    class Program
    {


        static void Main(string[] args)
        {
            GetName();
            GetTimes();
            GetRows();
            CreateMatrix();

        }
        public static string GetName()
        {
            Console.WriteLine("What is your name?");
            string name=Console.ReadLine();

            return name;

        }

        public static int GetTimes()
        {
            Console.WriteLine("Times to repeat?");
            int times= int.Parse(Console.ReadLine());

            return times;

        }

        public static int[] GetRows()
        {

            int[] dim = new int[2];
            Console.WriteLine("How many rows?");
            int rows = int.Parse(Console.ReadLine());
            dim[0] = rows;
            Console.WriteLine("How many columns?");
            int columns = int.Parse(Console.ReadLine());
            dim[1] = rows;


            return dim;

        }

        public static string[,] CreateMatrix(int dim, string name)
        {


            string[,] matrix = new string[2,2];
            foreach (string nam in name)
            matrix[2,2]=name;
           

            return matrix;
        }


        public static void Output(string name, int times)
        {
            Console.WriteLine(name);

            
        }

    }
}
