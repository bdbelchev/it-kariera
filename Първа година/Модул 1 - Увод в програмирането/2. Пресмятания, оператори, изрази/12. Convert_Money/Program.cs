using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Convert_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            double usd = 1.79549;
            double eur = 1.95583;
            double gbp = 2.53405;
            double result = 0;
            switch (from)
            {
                case "BGN":
                    switch (to)
                    {
                        case "USD":
                            result = amount / usd;
                            break;
                        case "EUR":
                            result = amount / eur;
                            break;
                        case "GBP":
                            result = amount / gbp;
                            break;
                    }
                    break;
                case "USD":
                    switch (to)
                    {
                        case "BGN":
                            result = amount * usd;
                            break;
                        case "EUR":
                            result = (amount * usd) / eur;
                            break;
                        case "GBP":
                            result = (amount * usd) / gbp;
                            break;
                    }
                    break;
                case "EUR":
                    switch (to)
                    {
                        case "USD":
                            result = (amount * eur) / usd;
                            break;
                        case "BGN":
                            result = amount * eur;
                            break;
                        case "GBP":
                            result = (amount * eur) / gbp;
                            break;
                    }
                    break;
                case "GBP":
                    switch (to)
                    {
                        case "USD":
                            result = (amount * gbp) / usd;
                            break;
                        case "EUR":
                            result = (amount * gbp) / eur;
                            break;
                        case "BGN":
                            result = amount * gbp;
                            break;
                    }
                    break;
            }
            Console.WriteLine(Math.Round(result, 2) + $" {to}");
        }
    }
}
