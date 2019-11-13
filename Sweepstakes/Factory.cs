using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Factory
    {
        public static ISweepstakesManager ChooseManager()
        {
            ISweepstakesManager manager;
            string choice = UserInterface.ChooseStackOrQueue();
            if (choice == "queue")
            {
                manager = new SweepstakesQueueManager();
                return manager;
            }
            else if (choice == "stack")
            {
                manager = new SweepstakesStackManager();
                return manager;
            }
            else
            {
                return ChooseManager();
            }
        }
    }
}
