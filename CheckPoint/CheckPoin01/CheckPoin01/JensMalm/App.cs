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

            return Console.ReadLine().Split('-');                           //TODO: Lägg till parametern i Split-anropet StringSplitOptions.RemoveEmptyEntries
        }



        static void WhatToDo(string[] triangles)                             //TODO: Tydligare metodnamn.
        {
            foreach (string triangle in triangles)
            {
                int height = int.Parse(triangle.Substring(1));
                if (triangle.Contains("A")!=true)
                    APrintTriangles(height);                                //Spetsen uppåt
                else
                    BPrintTriangles(height);                                //Spetsen nedåt
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