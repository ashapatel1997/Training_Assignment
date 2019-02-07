using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> PrimeMinisterData = new Dictionary<int, string>();
            PrimeMinisterData.Add(1998,"Atal Bihari Vajpayee");
            PrimeMinisterData.Add(2014,"Narendra Modi");
            PrimeMinisterData.Add(2004,"Manmohan Singh");

          foreach(var data in PrimeMinisterData)
          {
              Console.WriteLine("Year:" + data.Key + "\nPrime Minister:"+data.Value+"\n\n");
          }

            foreach (var data in PrimeMinisterData)
            {
                if(data.Key==2004)
                    Console.WriteLine("Prime Minister of 2004:" + data.Key);
            }

            Console.WriteLine("Current Prime Minister:");
            string newPM=Console.ReadLine();
            PrimeMinisterData.Add(2019, newPM);

            Console.WriteLine("\nSorted Prime Minister by year:\n");
            var value = from x in PrimeMinisterData orderby x.Key ascending select x;
            foreach(var x in value)
            {
                Console.WriteLine(x.Key + "\t" + x.Value);
            }
        }
    }
}
