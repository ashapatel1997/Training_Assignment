using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Words = new ArrayList() { "boat", "house", "cat", "river", "cupboard" };

            foreach (var _Words in Words) //plurals
                Console.WriteLine(_Words+"s");

            Words[1] = "home"; //change 2nd position

            Console.WriteLine("Enter New Word:"); //added new word
            string NewWord = Console.ReadLine();
            Words.Add(NewWord);
            
            Console.WriteLine("\nLength of the list:"+Words.Count);
         

            Console.WriteLine("\nWords contains length of characters as 7...\n");
            int count = 0;
            for (int i=0;i<Words.Count;i++)
            {
                if(Words[i].ToString().Length == 7)
                {
                    Console.WriteLine(Words[i]);
                    count++;
                }
                    
            }
            if (count == 0)
                Console.WriteLine("No word found");

            Console.WriteLine("\nWord at 3rd position:"+Words[2]+"\n");

            Console.WriteLine("\nWords in ascending order...\n");
            Words.Sort();
            foreach (var _Words in Words)
                Console.WriteLine(_Words);

            Console.WriteLine("\nWords in reverse order...\n");
            Words.Reverse();
            foreach (var _Words in Words)
                Console.WriteLine(_Words);

           
        }
    }

   
}
