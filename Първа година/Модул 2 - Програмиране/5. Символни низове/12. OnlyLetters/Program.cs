using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputMessage = Console.ReadLine();

            for (int i = 0; i < inputMessage.Length - 1; i++)
            {
                if (int.TryParse(inputMessage[i].ToString(), out _))
                {
                    if (!int.TryParse(inputMessage[i + 1].ToString(), out _))
                    {
                        inputMessage = inputMessage.Replace(inputMessage[i], inputMessage[i + 1]);

                        if (i > 0 && int.TryParse(inputMessage[i - 1].ToString(), out _))
                        {
                            inputMessage = inputMessage.Remove(i - 1, 1);
                        }
                    }
                }
            }

            Console.WriteLine(inputMessage);
        }
    }
}
