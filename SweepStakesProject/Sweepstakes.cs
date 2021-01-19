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
        private int keyValue;
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
            contestants = new Dictionary<int, Contestants>();
            keyValue = 0;
        }
        // METHODS(CAN DO)
        public void RegisterContestant(Contestants contestant)
        {
            contestants.Add(keyValue, contestant); // adds contestant to contestants dictionary
            keyValue++;                            // Increment the dictionary key by one each time a contestant is added
        }
        public Contestants PickWinner()
        {

            Random newRandom = new Random();
            int pickWinner = newRandom.Next(0, contestants.Count);
            return contestants[pickWinner];
        }
        public void PrintContestantInfo(Contestants contestant)
        {
            Console.WriteLine(contestant.FirstName);
            Console.WriteLine(contestant.LastName);
            Console.WriteLine(contestant.EmailAddress);
            Console.WriteLine(contestant.RegistrationNumber);
            Console.ReadLine();
        }
    }
}
