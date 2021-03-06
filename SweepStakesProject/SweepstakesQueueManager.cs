﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        private Queue<Sweepstakes> queue;
        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
        //MEMBER VARIABLES ( HAVE A )
        // create a sweepstakes queue manager class that uses the queue data structure as an underlying structure
        // Inherit from iSweepstakesManager

    }
}
