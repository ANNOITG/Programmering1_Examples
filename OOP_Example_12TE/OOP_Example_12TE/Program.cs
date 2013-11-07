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
            
            myPersons.Add(new Person() {pnr = "123456-6787", adress = "Tybblegatan 12", alder = 98});           //Lägger till 2 objekt i listan så vi slipper göra det runtime.
            myPersons.Add(new Person() { pnr = "126789-0101", adress = "Kärsta 313 Södergård", alder = 34 });   //-----------------------------------------------------------

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

                        int andraindex = 0;
                        foreach (Person p in myPersons) //Loopar ut alla objekt av klassen Person som finns i listan myPersons. Varje objekt kallas för "p"
                        {
                            Console.WriteLine(andraindex + ":\n" + p + "\n"); //Skriver ut data med hjälp av ToString()-metoden som vi skrivit i klassen Person
                            andraindex++; //Öka index med ett så det blir rätt med lista och val.
                        }

                        try
                        {
                            Console.WriteLine("Vilket index vill du ändra?");
                            int andIndex = int.Parse(Console.ReadLine());

                            Console.WriteLine("Personnummer?");
                            myPersons[andIndex].pnr = Console.ReadLine(); //SKriver över värdet för pnr

                            Console.WriteLine("Ålder?");
                            myPersons[andIndex].alder = int.Parse(Console.ReadLine()); //Se ovan

                            Console.WriteLine("Adress?");
                            myPersons[andIndex].adress = Console.ReadLine(); //Se ovan

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
