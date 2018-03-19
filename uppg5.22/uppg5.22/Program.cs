using System;
using System.Text;
using System.Diagnostics;


namespace uppg5._1
{
    class Program
    {
        static void Main(string[] args)
        {



            string repeatme = Text();
            int cycles = HowManyCycles();
            StopW(repeatme, cycles);
            StopW("hejhej", 75000);

        }
        static string Text()
        {
            string text = "HEj";
            return text;
        }

        static int HowManyCycles()
        {
            int cycles = 75000;

            return cycles;

        }

        static StringBuilder GenerateString_StringBuilder(string repeatme, int cycles)
        {
          

            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= cycles; i++)
            {
                

                result.Append(repeatme);

            }
            return result;
        }

        static void StopW(string repeatme, int cycles)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            GenerateString_StringBuilder(repeatme, cycles);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine($"it took {ts.Milliseconds} milliseconds");
        }


    }

}
