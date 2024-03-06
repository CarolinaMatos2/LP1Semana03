using System;
namespace HeroPerks
{
    [Flags]
    enum Perks
    {
        WaterBreathing = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }
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
}