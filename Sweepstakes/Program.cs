using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketingFirm marketing;
            string choice = UserInterface.ChooseStackOrQueue();
            if (choice == "queue")
            {
                marketing = new MarketingFirm(new SweepstakesQueueManager());
            }
            else if(choice == "stack")
            {
                marketing = new MarketingFirm(new SweepstakesStackManager());
            }          
        }
    }
}
