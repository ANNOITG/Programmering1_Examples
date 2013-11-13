using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_implement
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> unsorted = new List<Person>(); //Listan med personer. Denna lista skapas när programmet startar.

            unsorted.Add(new Person() { pnr = "623456-6787", adress = "Tybblegatan 12", alder = 98 });           //Lägger till 2 objekt i listan så vi slipper göra det runtime.
            unsorted.Add(new Person() { pnr = "126789-0101", adress = "Kärsta 313 Södergård", alder = 34 });
            unsorted.Add(new Person() { pnr = "851212-7878", adress = "Kärsta 356 Östergård", alder = 23 });//-----------------------------------------------------------

            // Print the unsorted array
            for (int i = 0; i < unsorted.Count(); i++)
            {
                Console.WriteLine(unsorted[i] + " ");
            }

            Console.WriteLine();

            // Sort the array
            Quicksort(unsorted, 0, unsorted.Count() - 1);

            // Print the sorted array
            for (int i = 0; i < unsorted.Count; i++)
            {
                Console.WriteLine(unsorted[i] + " ");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        public static void Quicksort(List<Person> elements, int left, int right)
        {
            int i = left, j = right;
            Person pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].pnr.CompareTo(pivot.pnr) < 0)
                {
                    i++;
                }

                while (elements[j].pnr.CompareTo(pivot.pnr) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    Person tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
