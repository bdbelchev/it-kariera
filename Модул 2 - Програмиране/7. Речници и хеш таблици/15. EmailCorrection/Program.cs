using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.EmailCorrection
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (input != "stop")
            {
                emails.Add(input, Console.ReadLine());
                input = Console.ReadLine();
            }

            emails = emails.Where(mail => !mail.Value.EndsWith("uk") && !mail.Value.EndsWith("us")).ToDictionary(mail => mail.Key, mail => mail.Value);

            foreach (var email in emails)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");
            }
        }
    }
}
