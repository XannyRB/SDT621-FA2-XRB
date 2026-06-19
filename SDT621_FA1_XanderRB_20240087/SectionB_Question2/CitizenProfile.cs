using System;

namespace SectionB_Question2
{
    public class CitizenProfile
    {
        // Properties
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; private set; }
        public string CitizenshipStatus { get; set; }

        // Constructor
        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber?.Trim() ?? "";
            CitizenshipStatus = citizenshipStatus;

            Age = CalculateAge();
        }

        private int CalculateAge()
        {
            if (string.IsNullOrEmpty(IDNumber) || IDNumber.Length < 6)
                return 0;

            try
            {
                int year = int.Parse(IDNumber.Substring(0, 2));
                int month = int.Parse(IDNumber.Substring(2, 2));
                int day = int.Parse(IDNumber.Substring(4, 2));

                int fullYear = (year <= 26) ? (2000 + year) : (1900 + year);

                int currentYear = 2026;
                int age = currentYear - fullYear;

                if (month > 6 || (month == 6 && day > 20))
                {
                    age--;
                }

                return age;
            }
            catch
            {
                return -1;
            }
        }

        // ValidateID Method
        public string ValidateID()
        {
            if (IDNumber.Length != 13)
            {
                return "Invalid ID. Must be exactly 13 digits.";
            }

            foreach (char c in IDNumber)
            {
                if (!char.IsDigit(c))
                {
                    return "Invalid ID. Must contain numbers only.";
                }
            }

            if (Age < 0)
            {
                return "Invalid ID. Date components are invalid.";
            }

            return $"Valid ID. Citizen is {Age} years old.";
        }
    }
}