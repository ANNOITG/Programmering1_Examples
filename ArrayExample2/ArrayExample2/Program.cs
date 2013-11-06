using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sa = new string[7];

            sa[0] = "Hej";

            sa[1] = "Plats ett";


            sa[0] = "Plats 0";


            for (int i = 0; i < sa.Length; i++)
            {
                sa[i] = "hej hej";
            }

            Console.ReadKey();
        }
    }
}
