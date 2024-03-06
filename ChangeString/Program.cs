using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string inst = Console.ReadLine();

            Console.Write("Caráter: ")
            string substituir = Console.ReadLine();

            string resuldado = "";
            foreach (char c in b)
            {
                resuldado = (c == substituir) ? 'X' : c;
            }

            Console.WriteLine($"Será impresso: {resultado}")
        }
    }
}
