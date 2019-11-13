using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UserInterface
    {
        static string firstName;
        static string lastName;
        static string email;
        static int registrationNumber;

        static UserInterface()
        {

        }

        public static string GetFirstName()
        {
            Console.WriteLine("Please enter your first name.");
            firstName = Console.ReadLine();
            return firstName;
        }

        public static string GetLastName()
        {
            Console.WriteLine("Please enter your Last name.");
            lastName = Console.ReadLine();
            return lastName;
        }

        public static string GetEmail()
        {
            Console.WriteLine("Please enter your email.");
            email = Console.ReadLine();
            return email;
        }

        public static int GetRegistrationNumber()
        {
            registrationNumber = 10;
            return registrationNumber;
        }
    }
}
