using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1999,
                FirstName = "MİREM",
                LastName = "IŞILDAK",
                IdentificationNumber= 987654
            });
        }
    }
}
