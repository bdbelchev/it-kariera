namespace Debugging_Substring
{
    using System;

    public class Substring_broken
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p'; //was cyrillic р
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int endIndex = jump + 1; //include 'p'

                    if (endIndex + i > text.Length)
                    {
                        endIndex = text.Length - i;
                    } //check from current position and return characters left until end

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
