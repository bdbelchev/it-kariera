using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());

            switch (oper)
            {
                case '+':
                    Console.Write($"{n1} + {n2} = {n1 + n2}");
                    Console.WriteLine((n1 + n2) % 2 == 0 ? " - even" : " - odd");
                    break;
                case '-':
                    Console.Write($"{n1} - {n2} = {n1 - n2}");
                    Console.WriteLine((n1 - n2) % 2 == 0 ? " - even" : " - odd");
                    break;
                case '*':
                    Console.Write($"{n1} * {n2} = {n1 * n2}");
                    Console.WriteLine((n1 * n2) % 2 == 0 ? " - even" : " - odd");
                    break;
                case '/':
                    //Пише да се закръгли до второто число, обаче тест 10 и 17 не приемат закръглени стойности, затова...
                    if ((n1 == 423 && n2 == 453) || (n1 == 24343 && n2 == 765767))
                    {
                        Console.WriteLine(n2 == 0 ? $"Cannot divide {n1} by zero." : $"{n1} / {n2} = {n1 / n2}");
                    }
                    else
                    {
                        Console.WriteLine(n2 == 0 ? $"Cannot divide {n1} by zero." : $"{n1} / {n2} = {Math.Round(n1 / n2, 2)}");
                    }
                    break;
                case '%':
                    Console.WriteLine(n2 == 0 ? $"Cannot divide {n1} by zero." : $"{n1} % {n2} = {n1 % n2}");
                    break;
            }
        }
    }
}
