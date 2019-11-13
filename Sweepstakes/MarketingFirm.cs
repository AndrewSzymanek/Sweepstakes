using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        Sweepstakes sweepstakes;
        public ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        //member methods
        public void CreateSweepstakes(Sweepstakes sweepstakes, Contestant contestant)
        {
            sweepstakes = new Sweepstakes("");
            UserInterface.ChooseStackOrQueue();
            if (UserInterface.ChooseStackOrQueue() == "stack")
            {
                manager.InsertSweepstakes(sweepstakes);
            }
            else if (UserInterface.ChooseStackOrQueue() == "queue")
            {
                manager.InsertSweepstakes(sweepstakes);
            }
          
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo(contestant);
        }
    }
}
