using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] msv = new string[3]; //Stringvektor med 3 platser

            msv[0] = Console.ReadLine();
            msv[1] = "Hej hej";
            msv[2] = Console.ReadLine();

            foreach (string s in msv)
            {
                Console.WriteLine("Du skrev : " + s);
            }


            Random r = new Random();
            int[] myIv = new int[5]; //int-vektor med 5 platser

            for (int i = 0; i < myIv.Length; i++)
            {
                myIv[i] = r.Next(1, 100);
            }

            foreach (int x in myIv)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
        }
    }
}
