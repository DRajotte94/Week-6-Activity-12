using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6_Activity_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // read text file and save to string
            String text = System.IO.File.ReadAllText(@"C:\Users\drajo\Desktop\test.txt");

            // convert text to lowercase to remove case sensitivity
            text = text.ToLower();

            // break string into array of words
            String[] words = text.Split(' ');

            // increment through the array of words, if word ends in 'e' or 't' increment count by 1
            int count = 0;
            for (int i = 0; i < words.Length; i++ )
            {
                if (LastLetter(words[i]) == true) // calls method to check if the word ends in 'e' or 't'
                {
                    count++;
                }
            }

            // print out results
            Console.WriteLine("There are " + count + " words that end in 'e' or 't'.");

            // prevents console from closing until enter key is pressed
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        public static Boolean LastLetter(String word)
        {
            char[] charArray = word.ToCharArray(); // splits word into array of characters

            // if the last index (last letter) is 'e' or 't' the statement returns true
            if (charArray[charArray.Length - 1] == 'e' || charArray[charArray.Length - 1] == 't')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
