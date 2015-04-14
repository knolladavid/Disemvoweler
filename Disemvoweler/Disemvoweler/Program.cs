using System;

namespace Disemvoweler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Disemvoweler("Nickelback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
            // keep the console open
            Console.ReadKey();
        }

        public static string Disemvoweler(string guitarString)
        {
            //variable called "inVowels" - leave blank
            var inVowels = "";
            //variable called "inConstants" - leave blank
            var inConstants = "";
            //take "guitarString" input & change chars to lower case 
            var lower = guitarString.ToLower();

            for (var i = 0; i <= guitarString.Length - 1; i++)
            {
                // this will check the [i] variable for a vowel or special character
                if (lower[i].ToString() == "a" || lower[i].ToString() == "e" || lower[i].ToString() == "i" || lower[i].ToString() == "o" || lower[i].ToString() == "u" || lower[i].ToString() == "." || lower[i].ToString() == "," || lower[i].ToString() == "?" || lower[i].ToString() == "'" || lower[i].ToString() == "!" || lower[i].ToString() == " ")
                {
                    //if true add the char to "inVowels
                    inVowels = inVowels + lower[i].ToString();
                }
                else
                {
                    //else add the char to "inConstants
                    inConstants = inConstants + lower[i].ToString();
                }
            }

            // Write out the various string results

            
            Console.WriteLine("Original: " + guitarString);
            Console.WriteLine("Disemvoweled: " + inConstants);
            Console.WriteLine("Vowels Removed: " + inVowels);
            return inConstants;
        }
    }
}