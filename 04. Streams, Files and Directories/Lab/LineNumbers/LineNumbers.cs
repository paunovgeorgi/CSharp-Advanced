using System;

namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {

            using (StreamReader input = new StreamReader(inputFilePath))
            {
                using (StreamWriter output = new StreamWriter(outputFilePath))
                {
                        int num = 1;
                    while (!input.EndOfStream)
                    {
                        string currentLine = input.ReadLine();
                        output.WriteLine($"{num++}. {currentLine}");
                    }
                }

            }
        }
    }
}
