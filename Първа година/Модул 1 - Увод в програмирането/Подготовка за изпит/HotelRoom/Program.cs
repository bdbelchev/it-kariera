using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50 * days;
                    apartmentPrice = 65 * days;
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20 * days;
                    apartmentPrice = 68.70 * days;
                    break;
                case "July":
                case "August":
                    studioPrice = 76 * days;
                    apartmentPrice = 77 * days;
                    break;
            }

            if (month == "May" || month == "October")
            {
                if (days > 14)
                {
                    studioPrice -= 0.3 * studioPrice;
                }
                else if (days > 7)
                {
                    studioPrice -= 0.05 * studioPrice;
                }
            }
            else if ((month == "June" || month == "September") && days > 14)
            {
                studioPrice -= 0.2 * studioPrice;
            }

            if (days > 14)
            {
                apartmentPrice -= 0.1 * apartmentPrice;
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
