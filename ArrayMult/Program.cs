using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length = 6)
            {
                Console.WriteLine("Write six numbers: ");
                return;
            }
            float a11 = float.Parse(args[0]);
            float a12 = float.Parse(args[1]);
            float a13 = float.Parse(args[2]);
            float a14 = float.Parse(args[3]);
            float b1 = float.Parse(args[4]);
            float b2 = float.Parse(args[5]);

            float resultado1 = a11 * b1 + a12 * b2;
            float resultado2 = a21 * b1 + a22 * b2;
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);

        }
    }
}
