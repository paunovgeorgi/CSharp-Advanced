using System;

namespace OddLines
{
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);

            
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader input = new StreamReader(inputFilePath))
            {

            using (StreamWriter output = new StreamWriter(outputFilePath))
            {

            int line = 0;
            string currentLine = "";
            while (!input.EndOfStream) 
            {
                    currentLine = input.ReadLine();
                if (line % 2 != 0)
                {
                    output.WriteLine(currentLine);
                }

                line++;
            }
            }
            }

        }
    }
}
