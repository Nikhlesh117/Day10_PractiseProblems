using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProblem
{
    public class AgeValidator
    {
        public int ValidateAge(string ageInput)
        {
            if (string.IsNullOrEmpty(ageInput))
            {
                throw new InvalidAgeException("Invalid age entered. Age cannot be null or empty.");
            }

            if (!int.TryParse(ageInput, out int age))
            {
                throw new InvalidAgeException("Invalid age entered. Age must be a valid integer.");
            }

            if (age < 1)
            {
                throw new InvalidAgeException("Invalid age entered. Age must be a positive number.");
            }

            return age;
        }

        public string GetCategory(int age)
        {
            if (age >= 1 && age <= 14)
            {
                return "Children";
            }
            else if (age >= 15 && age <= 24)
            {
                return "Youth";
            }
            else if (age >= 25 && age <= 64)
            {
                return "Adults";
            }
            else if (age >= 65)
            {
                return "Seniors";
            }
            else
            {
                throw new InvalidAgeException("Invalid age entered. Age does not fall into any category.");
            }
        }
    }
}
