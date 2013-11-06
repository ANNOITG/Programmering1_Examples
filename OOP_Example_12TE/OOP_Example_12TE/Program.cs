using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example_12TE
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> myPersons = new List<Person>();

            while (true)
            {

                Console.WriteLine("Tryck A för att lägga till en ny person\n"
                                + "Tryck B för att skriva ut alla i listan\n"
                                + "Tryck X för att avsluta");

                string val = Console.ReadLine().ToLower();

                switch (val)
                {
                    case "a":

                        Person per = new Person();

                        Console.WriteLine("Personnummer?");
                        per.pnr = Console.ReadLine();

                        Console.WriteLine("Alder?");
                        per.alder = int.Parse(Console.ReadLine());

                        Console.WriteLine("Adress?");
                        per.adress = Console.ReadLine();


                        myPersons.Add(per);
                        
                        break;

                    case "b":
                        Console.WriteLine("Antal skapade persons: " + Person.counter);

                        foreach (Person p in myPersons)
                        {
                            Console.WriteLine(p + "\n");
                        }
                        break;

                    case "x":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Du gjorde inte ett korrekt val.");
                        Console.Clear();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
