using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1000_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            string dateString = Console.ReadLine();
            DateTime userDate = DateTime.ParseExact(dateString, "dd-MM-yyyy", provider);
            DateTime newDate = userDate.AddDays(999);
            Console.WriteLine(newDate.ToString("dd-MM-yyyy", provider));
        }
    }
}
