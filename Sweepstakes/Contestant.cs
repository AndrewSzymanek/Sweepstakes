using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //member variables
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNum;

        //member methods
        public void AssignFirstName()
        {
            Console.WriteLine("Please enter your first name.");
            firstName = Console.ReadLine();
        }
        public void AssignLastName()
        {
            Console.WriteLine("Please enter your last name.");
            lastName = Console.ReadLine();
        }
        public void CollectEmailAddress()
        {
            Console.WriteLine("Please enter your email address.");
            emailAddress = Console.ReadLine();
        }
    }
}
