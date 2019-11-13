using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;
        public Contestant()
        {
            
        }

        public void FirstName()
        {
            Console.WriteLine("Please enter your first name.");
            firstName = Console.ReadLine();
        }

        public void LastName()
        {
            Console.WriteLine("Please enter your Last name.");
            lastName = Console.ReadLine();
        }

        public void Email()
        {
            Console.WriteLine("");
            email = Console.ReadLine();
        }

        public void RegistrationNumber()
        {
            registrationNumber = 10;
        }
    }
}
