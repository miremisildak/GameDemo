using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class SaleManager : ISaleService
    {
        public void Buy(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName+gamer.LastName+ "named user"+ game.GameName+ "bought");
        }
    }
}
