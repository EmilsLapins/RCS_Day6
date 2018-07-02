using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCS_Day6

{
    class Repeat
    {
        public void Izvade()
        {
            Console.WriteLine("Ludzu ievadiet skaitli");
            string Skaitlis = Console.ReadLine();
            int Skaitlis1 = Convert.ToInt16(Skaitlis);

            string rezultats = Sharp(Skaitlis1);
            Console.WriteLine("Funkcija izdod: {0} ", rezultats);

            
            //Izvadit vai nu # vai ## atkariba no lietotaja ievades. Cilvekam jaievada vesels
            //skaitlis un jaizsauc funkcija Sharp(SEIT LIEKAM SKAITLISKU VERTIBU);
        }

        private string Sharp(int a)
        {


            string result;
            int skaitlisA = a;

            if (skaitlisA > 5)
            {
                //Console.WriteLine("##");
                 result = "##";
            }
            else
            {
               // Console.WriteLine("#");
                 result = "#";
            }

            
            //TODO ja int a lielaks par 5, tad atgriezt ##, ja ne, tad #
            return result;
        }
    }
}

