using System;
using System.Text;


namespace _5._4_Value_types
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = "APPLE";
            string nyfruit = "Apelin";
           // string newFruit = ChangeFruit();
            Print(fruit, nyFruit);
            
        }


        public void Print(string oldValue, string newValue)
        {
            Console.WriteLine($"before: {oldValue}");
            Console.WriteLine($"after: {newValue}");


        }

        public string ChangeFruit()
        {
            string nyFruit = "orange";
            return nyFruit;

        }
        //void ChangeAge(int age)
        //{

        //}
        //void ChangeDate(DateTime date)
        //{

        //}
        //void ChangePoint(Point_Struct point)
        //{

        //}

    }


  }



//    class Program
//    {
//        static void Main(string[] args)
//        { 

    //                {
    //                    Point_Struct point = new Point_Struct(3, 4);
    //                    Console.WriteLine($"Before: point={point}");
    //                    ChangePoint(point);
    //                    Console.WriteLine($"After: point={point}");
    //                }

    //                Console.WriteLine();

    //            var fruit = new Fruit("APPLE");
    //            Console.WriteLine($"Before: Fruit={fruit}");



    //            {
    //                    StringBuilder sb = new StringBuilder("Let's go dancing.");
    //                    Console.WriteLine($"Before= {sb}");
    //                    ChangeStringBuilder(sb);
    //                    Console.WriteLine($"After= {sb}");
    //                }
    //         }

    //            private static void ChangePoint(Point_Struct point)
    //            {
    //                point.X = 999;
    //                point.Y = 888;
    //            }

    //            private static void ChangeStringBuilder(StringBuilder sb)
    //            {
    //                sb.Append(" Yes that would be great!");
    //            }

    //        void ChangeFruit(string fruit)
    //        {
    //            fruit = "APPLe";

    //        }

    ////public class Point
    ////        {
    ////            public Point(int x, int y)
    ////            {
    ////                X = x;
    ////                Y = y;
    ////            }
    ////            public int X { get; set; }
    ////            public int Y { get; set; }

    ////            public override string ToString()
    ////            {
    ////                return $"({X},{Y})";
    ////            }
    ////        }

    //        public struct Point_Struct
    //        {
    //            public Point_Struct(int x, int y)
    //            {
    //                X = x;
    //                Y = y;
    //            }
    //            public int X { get; set; }
    //            public int Y { get; set; }

    //            public override string ToString()
    //            {
    //                return $"({X},{Y})";
    //            }

    //        }

    //        public class Fruit
    //        {
    //            public Fruit(string fruit)
    //            {
    //                public string fruit { get; set; }

    //            }


    //        }



