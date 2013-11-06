using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1; //deklarera utanför så att vi kan använda genom hela Main-metoden.

            while (true) //loopen för att börja om, om användaren inte gör rätt.
            {
                try //Byggfria satsen börjar här. "Försök med följande"
                {
                    tal1 = int.Parse(Console.ReadLine()); //Försök att parsa till heltal
                    break; //OM det går att parsa. Så breakar vi ur loopen.
                }
                catch (Exception ex) //Annars hamnar vi här. Det small. Användaren var dum
                {
                    Console.WriteLine(ex.Message); //Skriv ut felmeddelande
                }
            }           //Loopen slutar och börjar om.

            Console.WriteLine("Du skrev talet: " + tal1); // lite kod....

            Console.ReadKey(); //Tryck på på valfi tangent.... etc....

        }
    }
}
