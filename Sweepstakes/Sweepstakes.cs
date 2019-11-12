﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //member variables
        Random randomNumber;

        Dictionary<int, Contestant> contestants;

        //constructor
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
        }

        //member methods
        
        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = contestants.Count + 1;
            contestants.Add(contestant.registrationNumber, contestant);          
        }
        public int PickWinner(Contestant contestant)
        {
            int winningNumber = randomNumber.Next(1, contestants.Count);
            return winningNumber;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            int winner = PickWinner(contestant);
        }

    }
}
