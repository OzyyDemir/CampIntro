using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi hesaplandı.");
        }
    }
}
