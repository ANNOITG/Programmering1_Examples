using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimVectorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] mTDA = new string[3, 5];
            Random r = new Random();

            int xCord = r.Next(0, 3);
            int yCord = r.Next(0, 5);

            mTDA[xCord, yCord] = "*";

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    if (x == xCord && y == yCord)
                    {
                        break;
                    }
                    else
                    {
                        mTDA[x, y] = "";
                    }
                }//<----- End of Y loop
            }//<--- End of X loop


            int xGiss;
            int yGiss;

            while (true)
            {
                while (true) //<---- loop för inmatning av X och Y
                {
                    try
                    {
                        Console.WriteLine("X-kord? max 2");
                        xGiss = int.Parse(Console.ReadLine());
                        Console.WriteLine("Y-kord? max 4");
                        yGiss = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Endast heltal tack");
                    }
                }//<-- Slut på inmatning för x och y

                Console.Clear();

                try
                {
                    if (mTDA[xGiss, yGiss] == "*")
                    {
                        Console.WriteLine("HIT!!!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("MISS!!!");
                    }
                }
                catch
                {
                    Console.WriteLine("Du gissade utanför spelplanen... duktigt... *pat pat*");
                }
            }//<----- Slut på gissloopen


            Console.ReadKey();

        }//<---- end of main method
    }
}
