using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DirectoryTraversal
{
    using System;
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath);
            Dictionary<String, List<FileInfo>> extensions = new Dictionary<string, List<FileInfo>>();

            foreach (string file in files)
            {
                FileInfo  fileInfo = new FileInfo(file);
                if (!extensions.ContainsKey(fileInfo.Extension))
                {
                    extensions.Add(fileInfo.Extension, new List<FileInfo>());
                }
                    extensions[fileInfo.Extension].Add(fileInfo);
            }

            StringBuilder sb = new();

            foreach (var file in extensions.OrderByDescending(x=>x.Value.Count))
            {
                sb.AppendLine(file.Key);

                foreach (var name in file.Value.OrderBy(x=>x.Length))
                {
                    sb.AppendLine($"--{name.Name} - {(double)name.Length / 1024:f3}");
                }
            }



            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            File.WriteAllText(reportFileName, textContent);
        }
    }
}
