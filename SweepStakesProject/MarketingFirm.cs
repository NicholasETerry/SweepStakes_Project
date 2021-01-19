using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;
        // MEMBER VARIABLES ( HAVE A )
        // create a Markertingfirm class with functionality to create a sweepstakes
        // i want to implement dependency injection in my MarkertingFirm class so that i can utilize a sweepstakes manager
        // PROPERTIES (GET : SET)

        // CONSTRUCTOR
        public MarketingFirm( ISweepstakesManager manager) // Constructor Injection -  - - either queue or stack
        {
            
            _manager = manager;
        }

        // METHODS ( CAN DO )
        public void CreateSweepstake()
        {
            Sweepstakes newSweepStakes = new Sweepstakes(); // needs a string for sweepstakes name
        }
    }
}
