using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {

        public static string GetFirstName()
        {          
            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();
            return firstName;       
        }
        public static string GetLastName()
        {
            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();
            return lastName;
        }
        public static string GetEmailAddress()
        {
            Console.WriteLine("Please enter your email.");
            string emailAddress = Console.ReadLine();
            return emailAddress;
        }
        public static void PrintWinner(Contestant contestant)
        {
            Console.WriteLine($"The winner is: {contestant.firstName} {contestant.lastName}, {contestant.emailAddress}.");
        }
        public static string ChooseStackOrQueue()
        {
            Console.WriteLine("Write 'stack' or 'queue' to choose where you're storing your sweepstake.");
            string choice = Console.ReadLine();
            return choice;
           
        }
    }
}
