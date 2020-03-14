using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            //get first letter of word
            //move it to end of word
            //add ay to the end
            
            Console.WriteLine("Enter an English Sentence:  ");
            string userInput = Console.ReadLine();
            string[] words = userInput.Split(' ');

            foreach(var word in words)
            {
                if (word.Length != 1)
                {
                    Console.Write(word.Substring(1) + word[0] + "ay ");
                }
                else
                {
                    Console.Write("ay ");
                }
            }

            Console.ReadKey();
        }

   
    }


    
}
