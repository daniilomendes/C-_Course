using System.Text.RegularExpressions;

namespace HtmlEditor
{
    public static class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("MODO VISUALIÇÃO");
            Console.WriteLine("----------------------------------------");
            Replace(text);
            Console.WriteLine("----------------------------------------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strongRegex = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>", RegexOptions.IgnoreCase);

            int currentIndex = 0;
            foreach (Match match in strongRegex.Matches(text))
            {
                string before = text.Substring(currentIndex, match.Index - currentIndex);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(before);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(match.Groups[1].Value);

                currentIndex = match.Index + match.Length;
            }

            if (currentIndex < text.Length)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(text.Substring(currentIndex));
            }

            Console.WriteLine();
        }
    }
}