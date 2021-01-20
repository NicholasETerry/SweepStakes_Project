using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    static class UserInterface // made static !
    {
        //MEMBER VARIABLES ( HAVE A )
        // Create a user interface for any information the application would need to get from the user. One example would be the functionality
        // to assign a Contestant object a first name, last name, email address, and registration number
        // PROPERTIES(GET:SET)

        // CONSTRUCTOR

        // METHODS ( CAN DO )
        public static void SweepstakesNextTask()
        {
            // 1 register contestent  2 pick a winner  3 print contestent info
            Console.WriteLine("Please select what you would like to do next.\n\n");
            Console.WriteLine(" press 1 : to resister another contestent.\n" +
                " press 2 : to pick a sweepstakes winner.\n" +
                " press 3 : to print a contestent's information.\n" +
                "press 4 : Exit application\n");
            ConfirmSweepstakesNextTask(Convert.ToInt32(Console.ReadLine()));
        }
        public static void ConfirmSweepstakesNextTask(int selectedTask)
        {

        }
        public static Contestants RegisterContestants()
        {
            Contestants newContestant = new Contestants();
            return newContestant;
        }
        public static string ContestantFirstName()
        {
            bool isConfirmed;
            Console.WriteLine("Enter Contestant's First Name:");
            string firstName =Console.ReadLine();
            isConfirmed = Confirm(firstName);
            if (isConfirmed.Equals(false))
            {
                ErrorMessage(" Not a valid first name");
                ContestantFirstName();
            }
            return firstName;

        }
        public static string ContestantLastName()
        {
            bool isConfirmed;
            Console.WriteLine("Enter Contestant's Last Name:");
            string lastName = Console.ReadLine();
            isConfirmed = Confirm(lastName);
            if (isConfirmed.Equals(false))
            {
                ErrorMessage("Not a valid last name");
                ContestantLastName();
            }
            return lastName;
        }
        public static string ContestantEmailAddress()
        {
            bool isConfirmed;
            Console.WriteLine("Enter Contestant's Email Address:");
            string email = Console.ReadLine();
            isConfirmed = ConfirmEmail(email);
            if (isConfirmed.Equals(false))
            {
                ErrorMessage("Invalid email address");
                ContestantEmailAddress();
            }
            return email;
        }
        private static bool Confirm(string toConfirm)
        {
            return true; // need to complete
        }
        private static bool ConfirmEmail(string EmailToConfirm)
        {
            return true; // need to complete
        }
        private static void ErrorMessage(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            Console.ReadLine();
        }
        public static ISweepstakesManager GetManager()
        {
            Console.WriteLine("Please select which collection method to use.\n\n");
            Console.WriteLine(" press 1 for Queue\n" +
                " press 2 for Stack\n" +
                " press 3 for more information on the Queue and Stack collections methods");
            return ConfirmGetManagerInput(Convert.ToInt32(Console.ReadLine()));
        }
        public static ISweepstakesManager ConfirmGetManagerInput(int userInput)
        {
            ISweepstakesManager newManager;
            switch (userInput)
            {
                case 1:
                    Console.Clear();
                    newManager = new SweepstakesQueueManager();
                    break;
                case 2:
                    Console.Clear();
                    newManager = new SweepstakesStackManager();
                    break;
                case 3:
                    Console.Clear();
                    MoreInfo();
                    newManager = null;
                    GetManager();
                    break;
                default:
                    ErrorMessage("Not a valid answer");
                    newManager = null;
                    GetManager();
                    break;
            }
            return newManager;

        }
        public static void MoreInfo()
        {
            Console.WriteLine("The Stack Class represents a simple last-in-first-out (LIFO) non-generic collection of objects.\n");
            Console.WriteLine("The Queue Class represents a first-in, first-out collection of objects.\n");
        }
        public static string GetSeepstakesName()
        {
            Console.WriteLine("Enter name for the Sweepstakes.");
            return (Console.ReadLine());
        }
    }
}
