using System;
using System.Collections.Generic;
using System.Text;

namespace GameExe
{
    class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer)
        {
            Console.WriteLine("Sale game to:" +gamer.Name);
        }
    }
}
