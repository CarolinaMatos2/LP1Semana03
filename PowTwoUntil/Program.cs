using System;

namespace PowTwoUntil
{
    class Program
    {
        private static void Powers0f2Until5()
        {
            for (int i = 1; i <= (1 << 5); i = i << 1)
            {
                Console.Write.Line(i);
            }
        }
        static void Main(string[] args)
        {
            Powers0f2Until5();
            Powers0f2Until5();
        }
    }
}
