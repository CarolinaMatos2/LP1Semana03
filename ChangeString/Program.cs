using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string inst = Console.ReadLine();

            Console.Write("Caráter: ");
            char substituir = Console.ReadLine();

            string resuldado = "";
            foreach (char c in inst)
            {
                resuldado = (c == substituir) ? 'X' : c;
            }

            Console.WriteLine($"Será impresso: {resultado}");
        }
    }
}
