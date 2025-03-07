using System;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("!Unknown perk!");
                return;
            }
            
            string input = args[0].ToLower();
            int countW = 0, countS = 0, countA = 0, countD = 0;
            
            foreach (char c in input)
            {
                switch (c)
                {
                    case 'w': countW++; break;
                    case 's': countS++; break;
                    case 'a': countA++; break;
                    case 'd': countD++; break;
                    default:
                        Console.WriteLine("!Unknown perk!");
                        return;
                }
            }
            
            Perks playerPerks = Perks.None;
            if (countW % 2 == 1) playerPerks |= Perks.WarpShift;
            if (countS % 2 == 1) playerPerks |= Perks.Stealth;
            if (countA % 2 == 1) playerPerks |= Perks.AutoHeal;
            if (countD % 2 == 1) playerPerks |= Perks.DoubleJump;
            
            if (playerPerks == Perks.None)
            {
                Console.WriteLine("!No perks at all!");
                Console.WriteLine("!Not gonna make it!");
                return;
            }
            
            Console.WriteLine(playerPerks);
            
            if ((playerPerks & Perks.Stealth) != 0 && (playerPerks & Perks.DoubleJump) != 0)
            {
                Console.WriteLine("!Silent jumper!");
            }
            
            if ((playerPerks & Perks.AutoHeal) == 0)
            {
                Console.WriteLine("!Not gonna make it!");
            }
        }
    }
}