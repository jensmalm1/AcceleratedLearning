using System;

namespace _5._5ny
{

    class Punkt
    {

        //contrutor, returnerar inget.
        public Punkt(int x, int y)
        {
            Console.WriteLine("HEJ");
        }
    
       //public void ShowMeYourStuff()
       // {
       //     Console.WriteLine($"X är {x} och Y är {y}");
       // }

        //public static Punkt AddPoints(Punkt p)
        //{
        //    return new Punkt(p1.x + p2.y);
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Punkt(3, 4);
            var p2 = new Punkt(10, 20);
              
            //p1.ShowMeYourStuff();


        }
    }
}
