using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        { 
            foreach(string words in args)
            {
                if(words.Length > 6)
                {
                    break;
                }
                if(words.Length > 3)
                {
                    Console.WriteLine(words);
                }
            }
        }
    }
}
