using System;
using System.Collections.Generic;
using System.Text;

namespace GameExe
{
    interface IGamerService
    {
        void Update(Gamer gamer);
        void SignUp(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
