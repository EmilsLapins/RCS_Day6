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
            
            //izsaukt funkciju no otras klases
            Repeat atkartot = new Repeat();
            atkartot.Izvade();

            Console.ReadLine();
        }
    }
}
