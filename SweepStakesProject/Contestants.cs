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

        public Contestants()
        {
            FirstName = UserInterface.ContestantFirstName();
            LastName = UserInterface.ContestantLastName();
            EmailAddress = UserInterface.ContestantEmailAddress();
        }
    }
}
