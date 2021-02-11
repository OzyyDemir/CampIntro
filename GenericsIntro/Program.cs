using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> listem = new MyList<string>();
            listem.Add("Ali");

            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Book : Kitap");
        }
    }
}
