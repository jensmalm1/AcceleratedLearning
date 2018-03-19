using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoin01.JensMalm
{
    class App
    {
        public void run()
        {

            string[] kommando = GetKommando();

            WhatToDo(kommando);
           
        }




        static string[] GetKommando()
        {
            Console.WriteLine("Ange kommando ");

            return Console.ReadLine().Split('-');
        }



        static void WhatToDo(string[]triangles)
        {
            foreach (string stringtriangle in triangles)
            {
                int star = int.Parse(stringtriangle.Substring(1));
                if (stringtriangle.Contains("A")==true)
                
                    APrintTriangles(star);
                
                else
                    BPrintTriangles(star);
            }
            
        }

        static void APrintTriangles(int star)
        {

            

                for (int j = 1; j <= star; j++)
                {



                    for (int i = 1; i <= j; i++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }

        }
        static void BPrintTriangles(int star)
        {




                for (int j = star; j >= 1; j--)
                {



                    for (int i = 1; i <= j; i++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }

                
            
        }


            
      }
   }