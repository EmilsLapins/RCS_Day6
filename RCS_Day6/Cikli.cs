using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCS_Day6
{
    class Cikli
    {
        public void Piemers()
        {
            // Ciklu veidi : 
            // for, while, do.. while. 
            // i++ == i = i + 1 
            // i-- == i = i - 1

            for (int i = 0; i < 6; i++)  // (initializer; condition; iterator)  / (int i = 0; i < 6; i = i + 3)  - Var ari sadi!
            {
                Console.WriteLine("Test");
                if (i == 1)
                {
                    Console.WriteLine("Ir 3");
                }
            }

            for (int skaititajs= 7; skaititajs > 0; skaititajs--)
            {
                Console.WriteLine("Skaitam uz otru pusi");
            }

            Console.WriteLine("Cik reizes?");
            string input = Console.ReadLine();
            int robeza = Convert.ToInt16(input);

            for (int i = 0; i < robeza; i++)
            {
                Console.WriteLine(i + ". reize!");
            }

            
        }
        public void Faktorialis()
        {
            Console.WriteLine("Ievadiet skaitli: ");
            string input = Console.ReadLine();
            int robeza = Convert.ToInt16(input);

            int summa = 0;

           for (int i = 0; i < robeza + 1; i++)
           // for (int i = 1; i <= robeza; i++) //var ari sadi


            {
                summa = summa + i;
               // Console.WriteLine("Faktorialis ir {0}!", summa);
            }
           Console.WriteLine("Faktorialis ir {0}!", summa);
            

        }

        public void Reste()
        {
            Console.WriteLine("Ievadiet skaitli: ");
            
            int robeza = Convert.ToInt16(Console.ReadLine());
            
            string restite = "";
           //////////////// int length = GalaInput.Length;
            for (int i = 0; i < robeza ; i++)
            {
                restite = restite + "#";
            }
            // Console.WriteLine(length);

            Console.WriteLine(restite);

        }
    }
}
