namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {

            DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
            FileInfo[] infos = dirInfo.GetFiles("*", SearchOption.AllDirectories);
            double sum = 0;
            foreach (FileInfo file in infos)
            {
                sum += file.Length;
            }

            sum /= 1024;
            File.WriteAllText(outputFilePath, sum.ToString());

            //DirectoryInfo[] subDirs = dirInfo.GetDirectories(); 

            //Console.WriteLine(dirInfo.Name);
            //Console.WriteLine(dirInfo.FullName);
            //Console.WriteLine(dirInfo.CreationTime);
            //Console.WriteLine(dirInfo.LastAccessTime);

            //FileInfo[] files = dirInfo.GetFiles();

            //Console.WriteLine("\n--------------------------------------\n");
            //foreach (FileInfo file in files)
            //{
            //    Console.WriteLine(file.Name);
            //    Console.WriteLine(file.FullName);
            //    Console.WriteLine($"{file.Length}");
            //}

            //Console.WriteLine("\n--------------------------------------\n");

            //foreach (DirectoryInfo subDir in subDirs)
            //{
            //    Console.WriteLine(subDir.Name);
            //    Console.WriteLine(subDir.CreationTime);
            //    Console.WriteLine(subDir.Attributes);
            //}
        }
    }
}
