using System;

namespace CodewarsAlgorithm 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Quadrant(3, 6));
        }

        public static int Quadrant(int x, int y)
        {

            return (x > 0 && y > 0) ? 1 : (x < 0 && y > 0) ? 2 : (x > 0 && y < 0) ? 4 : 3;
        }
    }
}