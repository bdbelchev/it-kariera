using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace _06._FileSplitGzip
{
    class Program
    {
        static void Main(string[] args)
        {
            Split("../../../image.jpg", "../../..", 9);

            List<string> files = new StreamReader("../../../filesCreated.txt").ReadToEnd().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Assemble(files, "../../..");
        }

        static void Split(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream fs = new FileStream(sourceFile, FileMode.Open))
            {
                long totalSize = fs.Length;
                long chunkSize = totalSize / parts;

                for (int i = 1; i <= parts; i++)
                {
                    string path = $"{destinationDirectory}/Part {i}.gz";

                    using (GZipStream res = new GZipStream(new FileStream(path, FileMode.Create), CompressionMode.Compress))
                    {
                        byte[] buffer = new byte[chunkSize];

                        fs.Read(buffer, 0, (int)chunkSize);

                        res.Write(buffer);
                    }

                    using (FileStream list = new FileStream($"{destinationDirectory}/filesCreated.txt", FileMode.Append))
                    {
                        list.Write(Encoding.UTF8.GetBytes(path + Environment.NewLine));
                    }

                    using (StreamWriter ext = new StreamWriter($"{destinationDirectory}/extension.txt"))
                    {
                        ext.Write(String.Join("", sourceFile.TakeLast(3)));
                    }
                }
            }
        }

        static void Assemble(List<string> files, string destinationDirectory)
        {
            string extension = new StreamReader($"{destinationDirectory}/extension.txt").ReadToEnd();

            using (FileStream result = new FileStream($"{destinationDirectory}/assembled.{extension}", FileMode.Create))
            {
                foreach (string file in files)
                {
                    using (GZipStream fs = new GZipStream(new FileStream(file, FileMode.Open), CompressionMode.Decompress))
                    {
                        int readByte = fs.ReadByte();
                        while (readByte != -1)
                        {
                            result.WriteByte((byte)readByte);
                            readByte = fs.ReadByte();
                        }
                    }
                }
            }
        }
    }
}
