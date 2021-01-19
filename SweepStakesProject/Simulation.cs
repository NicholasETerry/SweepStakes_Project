using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            MarketingFirm newFirm = new MarketingFirm(UserInterface.GetManager()); // gets stack or queue manager
        }
    }
}
