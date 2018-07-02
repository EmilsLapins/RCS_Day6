using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCS_Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            // Task 1 izsaukt funkciju no otras klases
            Repeat atkartot = new Repeat();
           // atkartot.Izvade();

            // Task 2 Cikli
            Cikli cikls1 = new Cikli();
            // cikls1.Piemers();

            // Task 3 Faktorialis
            //cikls1.Faktorialis();

            //Task 4
            cikls1.Reste();





            Console.ReadLine();
        }
    }
}
