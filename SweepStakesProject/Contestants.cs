using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class Contestants
    {
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;
        // MEMBER VARIABLES ( HAVE A )
        // As a developer i want to create a Contestant class that has
        // 1. first name
        // 2. last name
        // 3. email address
        // 4. registration number
        //PROPERTIES (GET:SET)
        // CONSTRUCTOR
        public Contestants()
        {
            FirstName = UserInterface.CustomerFirstName();
            LastName = UserInterface.CustomerLastName();
            EmailAddress = UserInterface.CustomerEmailAddress();
            RegistrationNumber = GenerateRegistrationNumber();
        }

        // METHODS ( HAVE A )
        public int GenerateRegistrationNumber()
        {

        }
    }
}
