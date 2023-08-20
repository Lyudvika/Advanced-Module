namespace EvenLines
{
    using System;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath));
        }
        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            using StreamReader textToRead = new StreamReader(inputFilePath);

            int counter = 0;
            string line = string.Empty;
            while ((line = textToRead.ReadLine()) != null)
            {
                if (counter % 2 ==  0)
                {
                    string replacedSymbols = ReplaceSymbols(line);
                    string reversedLine = ReverseSymbols(replacedSymbols);
                    sb.AppendLine(reversedLine);
                }
                
                counter++;
            }

            return sb.ToString();
        }


        public static string ReplaceSymbols(string line)
        {
            StringBuilder sb = new StringBuilder(line);
            char[] symbolsToChange = { '-', ',', '.', '!', '?' };

            foreach (char symbol in symbolsToChange)
            {
                sb.Replace(symbol, '@');
            }

            return sb.ToString();
        }

        private static string ReverseSymbols(string line)
        {
            string[] reverseLine = line.Split(" ").Reverse().ToArray();

            return string.Join(" ", reverseLine);
        }
    }
}
