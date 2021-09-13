using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int doctors = 7;
            int waitingPatients = 0;
            int treatedPatients = 0;

            for (int i = 1; i <= days; i++)
            {
                int patientsToday = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && waitingPatients > treatedPatients)
                {
                    doctors++;
                }

                if (patientsToday < doctors)
                {
                    treatedPatients += patientsToday;
                }
                else
                {
                    treatedPatients += doctors;
                    waitingPatients += patientsToday - doctors;
                }
            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {waitingPatients}.");
        }
    }
}
