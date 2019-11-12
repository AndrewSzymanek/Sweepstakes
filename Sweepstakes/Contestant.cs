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
        public int registrationNumber;

        //constructor 
        public Contestant()
        {
            firstName = UserInterface.GetFirstName();
            lastName = UserInterface.GetLastName();
            emailAddress = UserInterface.GetEmailAddress();
            registrationNumber = UserInterface.GetRegNum();
        }

        //member methods

    }
}
