using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionB_Question1
{
    public class Resident
    {

        //Prperties for resident data
        public string Name { get; set; }
        public string Address { get; set; }
        public string AccountNumber { get; set; }
        public double MonthlyUitilityUsage { get; set; }

        //Constructor to initialize attributes
        public Resident(string name, string address, string accountNumber, double monthlyUitilityUsage)
        {
            Name = name;
            Address = address;
            AccountNumber = accountNumber;
            MonthlyUitilityUsage = monthlyUitilityUsage;
        }
    }
}
