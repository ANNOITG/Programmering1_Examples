using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mySA = new string[5];

            for (int i = 0; i < mySA.Length; i++)
            {
                mySA[i] = Console.ReadLine();
            }

            Console.WriteLine("Du har nu skrivit:");
            foreach (string ord in mySA)
            {
                Console.WriteLine(ord);
            }

            Console.ReadKey();
        }
    }
}
