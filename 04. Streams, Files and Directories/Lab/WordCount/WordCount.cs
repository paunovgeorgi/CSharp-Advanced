using System.Text.RegularExpressions;

namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
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
            using (StreamReader words = new StreamReader(wordsFilePath))
            {
                string regex = @"(?<word>[A-z]+['][A-z]+|[A-z]+)";
                string[] separateWords = words.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, int> wordsCount = new Dictionary<string, int>();
                foreach (string word in separateWords)
                {
                    wordsCount.Add(word.ToLower(), 0);
                }
                using (StreamReader text = new StreamReader(textFilePath))
                {
                    string fullText = text.ReadToEnd().ToLower();
                    MatchCollection matches = Regex.Matches(fullText, regex);
                    foreach (string word in separateWords)
                    {
                        foreach (Match match in matches)
                        {
                            if (match.Value == word)
                            {
                                wordsCount[word]++;
                            }
                        }
                    }
                    using (StreamWriter output = new StreamWriter(outputFilePath))
                    {
                        foreach (var pair in wordsCount.OrderByDescending(x=>x.Value))
                        {
                            output.WriteLine($"{pair.Key} - {pair.Value}");
                        }
                    }

                }
            }
        }
    }
}
