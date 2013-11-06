using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example_12TE
{
    class Person
    {
        public static int counter { get; set; }

        public Person()
        {
            counter++;
        }

        public string pnr { get; set; }
        public int alder { get; set; }
        public string adress { get; set; }

        public override string ToString()
        {
            return "Personnummer: " + pnr + "\nÅlder: " + alder + "\nAdress: " + adress;
        }
    }
}
