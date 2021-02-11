using System;

namespace GameExe
{
    public class GamerManager:IGamerService
    {
       public void SignUp(Gamer gamer)
        {
            Console.WriteLine("Well Done! You Sign Up."+gamer.Name);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Well Done! You Update something." + gamer.Name);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Well Done! You Fire." + gamer.Name);
        }

    }
}
