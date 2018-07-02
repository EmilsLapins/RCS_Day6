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

            Cikli cikls1 = new Cikli();
            Repeat atkartot = new Repeat();

            Console.WriteLine("1:Izvade 2:Piemers 3:Faktorialis 4: Reste1 5: Reste2");
            int izvele = Convert.ToInt16(Console.ReadLine());
            switch (izvele)
            {
                case 1:
                    // Task 1 izsaukt funkciju no otras klases
                    atkartot.Izvade();
                    break;
                case 2:
                    // Task 2 Cikli
                   
                    cikls1.Piemers();
                    break;
                case 3:
                    // Task 3 Faktorialis
                    cikls1.Faktorialis();
                    break;
                case 4:
                    //Task 4
                    
                    cikls1.Reste();
                    break;
                case 5:                    
                    cikls1.Reste2();
                    break;


            }

           


            

           
            

            Console.ReadLine();
        }
    }
}
