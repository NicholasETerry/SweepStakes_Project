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
            Console.WriteLine("Enter Contestant's First Name:");
            string firstName =Console.ReadLine();
            Confirm(firstName);
        }
        public static string CustomerLastName()
        {
            Console.WriteLine("Enter Contestant's Last Name:");
            string lastName = Console.ReadLine();
            Confirm(lastName);
        }
        public static string CustomerEmailAddress()
        {
            Console.WriteLine("Enter Contestant's Email Address:");
            string email = Console.ReadLine();
            ConfirmEmail(email);
        }
        private static bool Confirm(string toConfirm)
        {

        }
        private static bool ConfirmEmail(string EmailToConfirm)
        {

        }
    }
}
