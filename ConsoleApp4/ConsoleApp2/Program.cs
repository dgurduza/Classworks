using System;

namespace ConsoleApp2
{
    public class ReplacedString
    {
        private string replacedString;

        public ReplacedString(string s, string initialSubstring, string finalSubstring)
        {
            replacedString = s.Replace(initialSubstring, finalSubstring);
            do
            {
                if (!finalSubstring.Contains(initialSubstring))
                {
                    replacedString = replacedString.Replace(initialSubstring, finalSubstring);
                }
                else
                    break;
            } while (replacedString.IndexOf(initialSubstring)>=0);
        }

        public override string ToString()
        {
            return replacedString;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string initialSubstring = Console.ReadLine();
            string finalSubstring = Console.ReadLine();

            var replacedString = new ReplacedString(s, initialSubstring, finalSubstring);

            Console.WriteLine(replacedString);
        }
    }
}
