using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string phrase = Console.ReadLine();
            string character = Console.ReadLine();

            string modifiedPhrase = phrase.Replace(character, "x");
            Console.WriteLine(modifiedPhrase);
        }
    }
}