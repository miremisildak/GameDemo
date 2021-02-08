using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1999  && gamer.FirstName == "MİREM"  && gamer.LastName == "IŞILDAK"
                && gamer.IdentificationNumber==987654)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
