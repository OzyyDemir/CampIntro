using System;
using System.Collections.Generic;
using System.Text;

namespace GameExe
{
    class UserValidator : IUserValidator
    {
        public void Validate(Gamer gamer)
        {
            if (gamer.Name=="Akif")
            {
                Console.WriteLine("Added: "+gamer.Name);
            }
        }
    }
}
