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

        public MarketingFirm( ISweepstakesManager manager) // Constructor Injection -  - - either queue or stack
        {           
            _manager = manager;
            CreateSweepstake();
        }

        public void CreateSweepstake()
        {
            Sweepstakes newSweepStakes = new Sweepstakes(UserInterface.GetSeepstakesName());
        }
    }
}
