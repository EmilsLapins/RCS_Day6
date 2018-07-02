using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Repeat
    {
        public string Izvade()
        {
            Console.WriteLine("Ludzu ievadiet skaitli");
            string Skaitlis = Console.ReadLine();
            Skaitlis1 = Convert.ToInt16(Skaitlis);

            Sharp(skaitlis1);

            
            //Izvadit vai nu # vai ## atkariba no lietotaja ievades. Cilvekam jaievada vesels
            //skaitlis un jaizsauc funkcija Sharp(SEIT LIEKAM SKAITLISKU VERTIBU);
        }

        private string Sharp(int a)
        {
           
            
            string result = "";

            int skaitlisA = a

            if (skaitlisA > 5)
            {
                Console.WriteLine("##");
            } else
            {
                Console.WriteLine("#");
            }

            //TODO ja int a lielaks par 5, tad atgriezt ##, ja ne, tad #
            return result;
        }
    }
}
