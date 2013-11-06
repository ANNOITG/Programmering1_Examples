using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string inm1 = Console.ReadLine();
            string inm2 = Console.ReadLine();

            string svar = AddString(inm1, inm2);
            Console.WriteLine(svar);

            Console.ReadKey();
        }

        public static void Method1(string message)
        {
            Console.WriteLine("Nu är jag i metod1. Meddelande: " + message);
            Console.WriteLine("Nu skriver jag lite till");
        }

        public static string AddString(string s1, string s2)
        {
            if (s1.Length > 0 && s1.Length > 0)
            {
                return s1 + s2;
            }
            else
            {
                return "Error! You must input atlest 1 char in each parameter";
            }
        }

    }
}
