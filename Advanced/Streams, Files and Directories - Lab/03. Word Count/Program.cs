using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(wordsFilePath))
            {
                using (StreamReader textReader = new StreamReader(textFilePath))
                {
                    string[] words = reader.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string text = textReader.ReadToEnd().ToLower();

                    for (int i = 0; i < words.Length; i++)
                    {
                        Regex regex = new Regex(@"\b" + $"{words[i]}" + @"\b".ToLower());
                        MatchCollection matches = regex.Matches(text);
                        wordsCount.Add(words[i], matches.Count);
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var item in wordsCount.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}