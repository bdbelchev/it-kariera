using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int siteCount = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            string[] affectedSites = new string[siteCount];
            decimal siteLoss = 0;

            for (int i = 0; i < siteCount; i++)
            {
                string[] siteData = Console.ReadLine().Split(' ').ToArray();
                string siteName = siteData[0];
                long siteVisits = long.Parse(siteData[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(siteData[2]);

                affectedSites[i] = siteName;
                siteLoss += siteVisits * siteCommercialPricePerVisit;
            }

            BigInteger securityToken = BigInteger.Pow(securityKey, siteCount);

            foreach (string site in affectedSites)
            {
                Console.WriteLine(site);
            }

            Console.WriteLine($"Total loss: {siteLoss:f20}");
            Console.WriteLine($"Security token: {securityToken}");
        }
    }
}
