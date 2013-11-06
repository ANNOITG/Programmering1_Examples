using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggFri_TALa
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1;

            while (true)
            {
                try
                {
                    tal1 = int.Parse(Console.ReadLine());
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Endast heltal\n" + ex.Message);
                }
                finally
                {
                    Console.WriteLine("hello");
                }
            }


            Console.ReadKey();
        }
    }
}
