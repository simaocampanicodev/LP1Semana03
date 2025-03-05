using System;
using System.Linq;

namespace HeroPerk
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("!No perks at all!");
                Console.WriteLine("!Not gonna make it!");
                return;
            }

            Perks perks = 0;

            foreach (char c in args[0])
            {
                switch (c)
                {
                    case 'w':
                        perks |= Perks.WarpShift;
                        break;
                    case 'a':
                        perks |= Perks.Stealth;
                        break;
                    case 's':
                        perks |= Perks.AutoHeal;
                        break;
                    case 'd':
                        perks |= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("!Unknown perk!");
                        return;
                }
            }
            if (perks == 0)
            {
                Console.WriteLine("!No perks at all!");
                Console.WriteLine("!Not gonna make it!");
                return;
            }
            var activePerks = Enum.GetValues(typeof(Perks))
                                      .Cast<Perks>()
                                      .Where(p => perks.HasFlag(p))
                                      .Select(p => p.ToString())
                                      .ToArray();
            Console.WriteLine(string.Join(", ", activePerks));

            if (perks.HasFlag(Perks.Stealth) && perks.HasFlag(Perks.DoubleJump))
            {
                Console.WriteLine("!Silent jumper!");
            }
            if (!perks.HasFlag(Perks.AutoHeal))
            {
                Console.WriteLine("!Not gonna make it!");
            }
        }
    }
}