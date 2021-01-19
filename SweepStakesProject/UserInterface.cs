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
        public static string CustomerFirstName()
        {
            bool isConfirmed;
            Console.WriteLine("Enter Contestant's First Name:");
            string firstName =Console.ReadLine();
            isConfirmed = Confirm(firstName);
            if (isConfirmed.Equals(true))
            {
                return firstName;
            }
            else
            {
                ErrorMessage(" Not a valid first name");
                return "";
            }
        }
        public static string CustomerLastName()
        {
            bool isConfirmed;
            Console.WriteLine("Enter Contestant's Last Name:");
            string lastName = Console.ReadLine();
            isConfirmed = Confirm(lastName);
            if (isConfirmed.Equals(true))
            {
                return lastName;
            }
            else
            {
                ErrorMessage("Not a valid last name");
                return "";
            }
        }
        public static string CustomerEmailAddress()
        {
            bool isConfirmed;
            Console.WriteLine("Enter Contestant's Email Address:");
            string email = Console.ReadLine();
            isConfirmed = ConfirmEmail(email);
            if (isConfirmed.Equals(true))
            {
                return email;
            }
            else
            {
                ErrorMessage("Invalid email address");
                return "";
            }
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
                " press 2 for Stack\n\n" +
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
