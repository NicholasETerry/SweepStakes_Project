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
                return ErrorMessage();
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
                return ErrorMessage();
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
                return ErrorMessage();
            }
        }
        private static bool Confirm(string toConfirm)
        {

        }
        private static bool ConfirmEmail(string EmailToConfirm)
        {

        }
        private static string ErrorMessage()
        {
            string errorOne = "Invalid name";
            return errorOne;

        }
    }
}
