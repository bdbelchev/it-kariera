using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.GoodHand
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new[] { ' ', ',' };
            string inputString = Console.ReadLine();
            Dictionary<string, int> results = new Dictionary<string, int>();

            while (inputString != "JOKER")
            {
                string[] input = inputString.Split(':').ToArray();
                string name = input[0];
                string[] cards = input[1].Split(separators, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();

                foreach (string card in cards)
                {
                    int cardType = 0;

                    switch (card[card.Length - 1])
                    {
                        case 'S':
                            cardType = 4;
                            break;
                        case 'H':
                            cardType = 3;
                            break;
                        case 'D':
                            cardType = 2;
                            break;
                        case 'C':
                            cardType = 1;
                            break;
                    }

                    string cardString = card.Remove(card.Length - 1, 1);

                    int cardNumber = 0;

                    if (int.TryParse(cardString, out int number))
                    {
                        cardNumber = number;
                    }
                    else
                    {
                        switch (cardString)
                        {
                            case "J":
                                cardNumber = 11;
                                break;
                            case "Q":
                                cardNumber = 12;
                                break;
                            case "K":
                                cardNumber = 13;
                                break;
                            case "A":
                                cardNumber = 14;
                                break;
                        }
                    }

                    int cardValue = cardType * cardNumber;

                    if (results.ContainsKey(name))
                    {
                        results[name] += cardValue;
                    }
                    else
                    {
                        results.Add(name, cardValue);
                    }
                }

                inputString = Console.ReadLine();
            }

            foreach (var pair in results)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
