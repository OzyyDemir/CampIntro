using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class TasitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi hesaplandı.");
        }
    }
}
