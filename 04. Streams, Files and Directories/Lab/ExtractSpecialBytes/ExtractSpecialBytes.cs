using System.Linq;

namespace ExtractSpecialBytes
{
    using System;
    using System.IO;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            //using (FileStream image = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
            //{

            //    using (StreamReader bytesText = new StreamReader(bytesFilePath))
            //    {
            //        byte[] buffer = bytesText.ReadToEnd().Split("\n", StringSplitOptions.RemoveEmptyEntries)
            //            .Select(byte.Parse).ToArray();

            //        using (FileStream output = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
            //        {
            //            output.Write(buffer, 0, buffer.Length);
            //        }

            //    }
            //}


            
                // Read the list of bytes from the text file
                byte[] bytesToExtract = File.ReadAllBytes(bytesFilePath);

                // Open the input binary file for reading
                using (FileStream inputFileStream = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
                {
                    // Create the output binary file for writing
                    using (FileStream outputFileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                    {
                        int bytesRead;
                        byte[] buffer = new byte[4096]; // Buffer to read and write data

                        while ((bytesRead = inputFileStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            // Check if any of the read bytes match the bytes to extract
                            for (int i = 0; i < bytesRead; i++)
                            {
                                if (Array.IndexOf(bytesToExtract, buffer[i]) != -1)
                                {
                                    // Write the matched byte to the output file
                                    outputFileStream.WriteByte(buffer[i]);
                                }
                            }
                        }
                    }
                
                }
        }
    }
}
