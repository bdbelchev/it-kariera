using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Convert_Rad_Deg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter angle in radians: ");
            double rad = double.Parse(Console.ReadLine());
            double deg = rad * (180) / (Math.PI);
            Console.WriteLine(Math.Round(deg));
        }
    }
}
