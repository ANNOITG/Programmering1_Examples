using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MyVector = new string[5];

            for (int i = 0; i < MyVector.Length; i++)
            {
                MyVector[i] = Console.ReadLine();
            }


            foreach (string s in MyVector)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
