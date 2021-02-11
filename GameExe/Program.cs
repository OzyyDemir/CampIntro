using System;

namespace GameExe
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Name = "Akif";
            gamer1.GamerId = 1;

            UserValidator validator = new UserValidator();
            validator.Validate(gamer1);
        }
    }


}
