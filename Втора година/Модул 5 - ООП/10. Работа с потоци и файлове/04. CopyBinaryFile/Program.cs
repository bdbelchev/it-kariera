using System;
using System.IO;

namespace _04._CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream img = new FileStream("../../../image.jpg", FileMode.Open);

            FileStream copy = new FileStream("../../../copy.jpg", FileMode.Create);

            using (img)
            {
                using (copy)
                {
                    int readByte = img.ReadByte();
                    while (readByte != -1)
                    {
                        copy.WriteByte((byte) readByte);
                        readByte = img.ReadByte();
                    }
                }
            }
        }
    }
}
