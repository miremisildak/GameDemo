using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Recorded");
            }
            else
            {
                Console.WriteLine("Validation failed , registration failed");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Updated");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Deleted");
        }
    }
}
