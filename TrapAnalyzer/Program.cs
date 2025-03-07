using System;

namespace TrapAnalyzer
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            TrapType trap = Enum.Parse<TrapType>(args[0]);
            PlayerGear gear = ParseGear(args);
            bool survives = CanSurviveTrap(trap, gear);
            DisplayResult(trap, survives);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the player gear.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The player gear.</returns>
        private static PlayerGear ParseGear(string[] args)
        {
            PlayerGear gear = PlayerGear.None;

            for (int i = 1; i < args.Length; i++)
            {
                if (Enum.TryParse(args[i], out PlayerGear parsedGear))
                {
                    gear |= parsedGear;
                }
            }
            return gear;
        }

        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trap">The trap the player falls into.</param>
        /// <param name="gear">The gear the player has.</param>
        /// <returns>Whether the player survived the trap or not.</returns>
        private static bool CanSurviveTrap(TrapType trap, PlayerGear gear)
        {
            return trap switch
            {
                TrapType.FallingRocks => (gear & PlayerGear.Helmet) != 0,
                TrapType.SpinningBlades => (gear & PlayerGear.Shield) != 0,
                TrapType.PoisonGas => (gear & PlayerGear.Helmet) != 0 && (gear & PlayerGear.Shield) != 0,
                TrapType.LavaPit => (gear & PlayerGear.Boots) != 0,
                _ => false
            };
        }

        /// <summary>
        /// Display information on whether the player survived the trap or not.
        /// </summary>
        /// <param name="trap">The trap the player has fallen into.</param>
        private static void DisplayResult(TrapType trap, bool survives)
        {
            if (survives)
            {
                Console.WriteLine($"Player survives {trap}");
            }
            else
            {
                Console.WriteLine($"Player dies due to {trap}");
            }
        }
    }
}