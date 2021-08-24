using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            sehirler2.Add("Bursa");

            Console.WriteLine(sehirler.Count);
            Console.WriteLine(sehirler2.Count);

            foreach (var item in sehirler2.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
