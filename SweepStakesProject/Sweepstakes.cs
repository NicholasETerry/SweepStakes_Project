using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class Sweepstakes
    {
        private string name;
        private Dictionary<int, Contestants> contestants;
        private int keyValue;

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
            RegisterContestant(UserInterface.RegisterContestants());
        }

        public void RegisterContestant(Contestants contestant)
        {
            contestants.Add(keyValue, contestant);
            keyValue++;                            
            contestant.RegistrationNumber = keyValue;
            ConfirmSweepstakesNextTask(UserInterface.SweepstakesNextTask());
        }
        public Contestants PickWinner()
        {
            Random newRandom = new Random();
            int pickWinner = newRandom.Next(0, contestants.Count);
            UserInterface.Winner();
            PrintContestantInfo(contestants[pickWinner]);
            return contestants[pickWinner];
        }
        public void PrintContestantInfo(Contestants contestant)
        {
            Console.WriteLine("First name: "+ contestant.FirstName);
            Console.WriteLine("Last name: "+ contestant.LastName);
            Console.WriteLine("Email Address: " + contestant.EmailAddress);
            Console.WriteLine("Registration Number: " + contestant.RegistrationNumber);
            Console.ReadLine();
            ConfirmSweepstakesNextTask(UserInterface.SweepstakesNextTask());
        }
        public void ConfirmSweepstakesNextTask(int selectedTask)
        {
            switch (selectedTask)
            {
                case 1:
                    Console.Clear();
                    RegisterContestant(UserInterface.RegisterContestants());
                    break;
                case 2:
                    Console.Clear();
                    PickWinner();
                    break;
                case 3:
                    Console.Clear();
                    PrintContestantInfo(GetInfo(UserInterface.GetContestantInfo()));
                    break;
                default:
                    break;
            }
        }
        public Contestants GetInfo(int keyValue)
        {
            bool isValue = false;
            while (isValue.Equals(false))
            {
                if(keyValue > contestants.Count - 1 )
                {
                    UserInterface.ErrorMessage("Invalid entry. There are " + contestants.Count.ToString() + " values availible.\n" +
                        "Enter key value again please.");
                }
                else
                {
                    isValue = true;
                }
            }
            return contestants[keyValue];
        }
    }
}
