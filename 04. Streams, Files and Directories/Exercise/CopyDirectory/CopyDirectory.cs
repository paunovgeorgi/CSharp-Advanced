﻿using System.IO;

namespace CopyDirectory
{
    using System;
    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }

            Directory.CreateDirectory(outputPath);
            string[] filesToCopy = Directory.GetFiles(inputPath);


            foreach (string file in filesToCopy)
            {
                string fileName = Path.GetFileName(file);
                string destination = Path.Combine(outputPath, fileName);

                File.Copy(file, destination);
            }
        }
    }
}
