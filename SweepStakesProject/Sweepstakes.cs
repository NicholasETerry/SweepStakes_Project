using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class Sweepstakes
    {
        //MEMBER VARIABLES ( HAVE A )
        private string name;
        private Dictionary<int, Contestants> contestants;
        // Create a sweepstakes class that uses the Dictionary data structure as an underlying structure. The sweepstakes class will have the
        // following methods with full implementation( write the functionality ) of each method.
        // ---------
        // As a developer, I want to use the factory design pattern to allow a user to choose between a SweepstakesStackManager or 
        // a SweepstakesQueueManager to manage the sweepstakes objects.

        //PROPERTIES (GET : SET)
        public string Name
        {
            get => name;
            set => name = value;
        }
        // CONSTRUCTOR
        public Sweepstakes(string name)
        {
            Name = name;
        }
        // METHODS(CAN DO)
        public void RegisterContestant(Contestants contestant)
        {

        }
        public Contestants PickWinner()
        {

        }
        public void PrintContestantInfo(Contestants contestant)
        {

        }
    }
}
