﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        Sweepstakes newSweepstake;
        public ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public void CreateSweepstakes(Sweepstakes sweepstakes, Contestant contestant)
        {
            newSweepstake = new Sweepstakes(UserInterface.GetSweepstakeName());
            manager.InsertSweepstakes(sweepstakes);
        }
    }
}
