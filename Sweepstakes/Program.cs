﻿using System;
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
            ISweepstakesManager manager = Factory.ChooseManager();
            MarketingFirm marketing = new MarketingFirm(manager);          
        }
    }
}
