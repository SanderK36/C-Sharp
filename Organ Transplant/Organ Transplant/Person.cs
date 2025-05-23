using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Organ_Transplant
{
    internal class Person
    {
        public string Name { get; private set; }
        public int HealthyKidneys { get; private set; }
        public bool IsAlive { get; private set; }

        public Person(string name, int healthyKidneys, bool isAlive)
        {
            Name = name;
            HealthyKidneys = healthyKidneys;
            IsAlive = isAlive;
        }

        public void DonateKidney()
        {
            if (HealthyKidneys > 0)
            {
                HealthyKidneys--;
                Console.WriteLine($"{Name} has donated a kidney. Remaining healthy kidneys: {HealthyKidneys}.");
            }
            else
            {
                Console.WriteLine($"{Name} has no healthy kidneys to donate.");
            }

        }

        public bool ReceiveKidney()
        {
            Random random = new Random();
            int successRate = random.Next(0, 100)+1;
            if(successRate <= 80)
            {
                HealthyKidneys++;
                IsAlive = true;
                Console.WriteLine($"{Name} has successfully received a kidney. Total healthy kidneys: {HealthyKidneys}.");
                return true;
            }
            else
            {
                Console.WriteLine($"Transplantation failed for {Name}! The kidney was not compatible.");
                IsAlive = false;
                return false;
            }
        }

        public void CheckStatus()
        {
            if (IsAlive)
            {
                Console.WriteLine($"{Name} is alive with {HealthyKidneys} healthy kidneys.");
            }
            else
            {
                Console.WriteLine($"{Name} is not alive.");
            }
        }
    }
}
