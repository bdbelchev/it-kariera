using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _05._FileSplit
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
                    string path = $"{destinationDirectory}/Part {i}.{string.Join("", sourceFile.TakeLast(3))}";

                    using (FileStream res = new FileStream(path, FileMode.Create))
                    {
                        byte[] buffer = new byte[chunkSize];

                        fs.Read(buffer, 0, (int)chunkSize);

                        res.Write(buffer);
                    }

                    using (FileStream list = new FileStream($"{destinationDirectory}/filesCreated.txt", FileMode.Append))
                    {
                        list.Write(Encoding.UTF8.GetBytes(path + Environment.NewLine));
                    }
                }
            }
        }

        static void Assemble(List<string> files, string destinationDirectory)
        {
            using (FileStream result = new FileStream($"{destinationDirectory}/assembled.{string.Join("", files.First().TakeLast(3))}", FileMode.Append))
            {
                foreach (string file in files)
                {
                    using (FileStream fs = new FileStream(file, FileMode.Open))
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
