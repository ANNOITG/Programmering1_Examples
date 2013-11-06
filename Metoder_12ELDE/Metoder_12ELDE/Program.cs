using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_12ELDE
{
    class Program
    {
        static void Main(string[] args) // <---- Den som körs!!!!
        {
            //Hej("Välkommen till ITG");
            //Hej("Nu är vi på Hej igen");

            //int tal1 = ReadInt();
            //int tal2 = ReadInt();



            //Console.WriteLine(tal1 + tal2);


            Console.WriteLine(AddString("EttHEJEHJ   ", "Två"));


            Console.ReadKey();
        }

        public static void Hej(string message)
        {
            Console.WriteLine("Och nu ekot");
            Console.WriteLine(message);
        }

        public static int ReadInt()
        {
            string inm = Console.ReadLine();

            return int.Parse(inm);
        }

        public static string AddString(string inm1, string inm2)
        {
            return inm1 + inm2;
        }

    }
}
