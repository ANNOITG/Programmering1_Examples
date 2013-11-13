using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_implement
{
    class Person : IComparable
    {
        public static int counter { get; set; }

        public Person()
        {
            counter++;
        }

        public string pnr { get; set; }
        public int alder { get; set; }
        public string adress { get; set; }

        public int CompareTo(object person)
        {

            if (this.pnr == ((Person)person).pnr)
            {
                return 0;
            }
            else if (this.pnr.CompareTo(((Person)person).pnr) < 1)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return "Personnummer: " + pnr + "\nÅlder: " + alder + "\nAdress: " + adress;
        }
    }
}
