using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the person's age:");
            string ageInput = Console.ReadLine();

            try
            {
                AgeValidator ageValidator = new AgeValidator();
                int age = ageValidator.ValidateAge(ageInput);

                if (age != -1)
                {
                    string category = ageValidator.GetCategory(age);
                    Console.WriteLine($"The person falls into the category: {category}");
                }
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
