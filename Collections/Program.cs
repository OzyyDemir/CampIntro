using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Ali", "Veli", "Mehmet" };
            Console.WriteLine(names[0]);
            names.Add("Mustafa");
            Console.WriteLine(names[3]);
        }
    }
}
