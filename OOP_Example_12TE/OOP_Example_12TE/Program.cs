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

            List<Person> myPersons = new List<Person>(); //Listan med personer. Denna lista skapas när programmet startar.
            
            myPersons.Add(new Person() { pnr = "623456-6787", adress = "Tybblegatan 12",        alder = 98 });           //Lägger till 2 objekt i listan så vi slipper göra det runtime.
            myPersons.Add(new Person() { pnr = "126789-0101", adress = "Kärsta 313 Södergård",  alder = 34 });
            myPersons.Add(new Person() { pnr = "851212-7878", adress = "Kärsta 356 Östergård",  alder = 23 });//-----------------------------------------------------------

            myPersons.Sort(delegate(Person p1, Person p2) { return p1.pnr.CompareTo(p2.pnr); });
            
            //myPersons.Sort();
            //myPersons.Sort(delegate(Person p1, Person p2) { return p1.pnr.CompareTo(p2.pnr); });
            //Console.WriteLine("Vilken person baserat på personnummer; vill du ta fram?"); 
            //string pnr = Console.ReadLine();
            //Person person = myPersons.Single(p => p.pnr == pnr);

            while (true)
            {

                Console.WriteLine("Tryck A för att lägga till en ny person\n" //Lite alternativ för användaren. Lägg till, Skriv ut och Avsluta
                                + "Tryck B för att skriva ut alla i listan\n"
                                + "Tryck C för att ändra ett objekt\n"
                                + "Tryck D för att ta bort ett objekt\n"
                                + "Tryck E för att söka efter ett objekt\n"
                                + "Tryck X för att avsluta");

                string val = Console.ReadLine().ToLower(); //Läs in valet användaren gör och spara i variabeln "val".

                switch (val)
                {
                    case "a":

                        Person per = new Person(); //Skapa en variabel "per" (Person per) som fylls av ett nytt objekt av klassen Person ( = new Person() )


                        //Nedan fylles obejtet "per" på av användaren.
                        Console.WriteLine("Personnummer?");
                        per.pnr = Console.ReadLine();

                        Console.WriteLine("Alder?");
                        per.alder = int.Parse(Console.ReadLine());

                        Console.WriteLine("Adress?");
                        per.adress = Console.ReadLine();


                        myPersons.Add(per); //Obejtet "per" läggs till i listan myPersons. (Nu är listan inte tom längre)
                        
                        break;

                    case "b":
                        Console.WriteLine("Antal skapade Personer: " + Person.counter); //Anropar den statiska variabeln i klassen Personer (public static int counter)

                        foreach (Person p in myPersons) //Loopar ut alla objekt av klassen Person som finns i listan myPersons. Varje objekt kallas för "p"
                        {
                            Console.WriteLine(p + "\n"); //Skriver ut data med hjälp av ToString()-metoden som vi skrivit i klassen Person
                        }
                        break;

                    case "c":
                        Console.WriteLine("Ändra en post via index");

                       
                        foreach (Person p in myPersons) //Loopar ut alla objekt av klassen Person som finns i listan myPersons. Varje objekt kallas för "p"
                        {
                            Console.WriteLine(p + "\n"); //Skriver ut data med hjälp av ToString()-metoden som vi skrivit i klassen Person
                        }

                        try
                        {
                            Console.WriteLine("Vilken person baserat på personnummer; vill du ta fram?");
                            string andraPnr = Console.ReadLine();
                            Person andraPerson = myPersons.Single(p => p.pnr == andraPnr);

                            Console.WriteLine("Personnummer?");
                            andraPerson.pnr = Console.ReadLine(); //SKriver över värdet för pnr

                            Console.WriteLine("Ålder?");
                            andraPerson.alder = int.Parse(Console.ReadLine()); //Se ovan

                            Console.WriteLine("Adress?");
                            andraPerson.adress = Console.ReadLine(); //Se ovan

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message); //Om något går fel i runtime så skrivs ett felmeddelande ut.
                        }
                        break;

                    case "d":
                        Console.WriteLine("Ta bort en post via index");

                        int removeindex = 0;
                        foreach (Person p in myPersons) //Loopar ut alla objekt av klassen Person som finns i listan myPersons. Varje objekt kallas för "p"
                        {
                            Console.WriteLine(removeindex + ":\n" + p + "\n"); //Skriver ut data med hjälp av ToString()-metoden som vi skrivit i klassen Person
                            removeindex++; //Öka index med ett så det blir rätt med lista och val.
                        }

                        try
                        {
                            Console.WriteLine("Vilket index vill du ta bort?");
                            int remIndex = int.Parse(Console.ReadLine()); //Valet av index sparas i remIndex


                            Person perToRem = myPersons[remIndex]; //Hämta ut vilken person i listan som skall tas bort.
                                                                   //Baserat på index (remIndex). Sparas i perToRem

                            myPersons.Remove(perToRem); //Tar bort vårt valda objekt från listan.

                            Person.counter--; //Fipplar rätt countern
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message); //Om något får fel. Ex att indexet inte finns i listan så skrivs felmeddelande ut.
                        }

                        break;

                    case "e":
                        Console.WriteLine("Skriv in sökord:");
                        string sokOrd = Console.ReadLine();

                        var sokRes = from p in myPersons
                                     where p.pnr.Contains(sokOrd)
                                        || p.alder.ToString().Contains(sokOrd)
                                        || p.adress.Contains(sokOrd)
                                     select p;

                        //Förklaringen till hur LINQ-Söningen funkar/tänker
                        //List<Person> SearchRes = new List<Person>();
                        //foreach (Person p in myPersons)
                        //{
                        //    if (p.pnr.Contains(sokOrd) || p.alder.ToString().Contains(sokOrd) || p.adress.Contains(sokOrd))
                        //    {
                        //        SearchRes.Add(p);
                        //    }
                        //}

                        foreach (Person p in sokRes)
                        {
                            Console.WriteLine(p);
                        }

                        break;
                    case "x":
                        Environment.Exit(0); //Avsluter programmet med koden 0
                        break;

                    default:
                        Console.WriteLine("Du gjorde inte ett korrekt val.");
                        Console.Clear();
                        break;
                } //<---- Switch end
            }//<----- Loope end
        }//<----- Main(string[] args) end
    }//<---- Class Program end
}//<--- namespace end
