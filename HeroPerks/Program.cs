using System;

[Flags]
enum WoWRoles
{
    WaterBreathing = 1
    Stealth = 2
    AutoHeal = 4
    DoubleJump = 8
}

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 1)
            {
                Console.WriteLine("");
                return;
            }
            WoWRoles roles = 0;

            foreach (char l in args[0])
            {
                
            }
        }
    }
}
