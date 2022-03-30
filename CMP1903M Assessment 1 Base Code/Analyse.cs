using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }

            IDictionary<char, int> chars = new Dictionary<char, int>();
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            bool debug = false;

            foreach (char c in input)
            {
                if (c == '*') // prioritize ending on an asterisk
                {
                    if (debug) Console.WriteLine("Stop right there!");
                    break;
                }

                if (c == '.') // sentences
                {
                    if (debug) Console.WriteLine("Sentence counted.");
                    values[0]++;
                    continue;
                }

                if (!Char.IsLetter(c)) // rule out any symbols or spaces
                {
                    if (debug) Console.WriteLine(c + " is not a letter.");
                    continue; 
                }

                chars.TryGetValue(c, out int val);
                chars[c] = val + 1;

                int vindex = Array.IndexOf(vowels, Char.ToLower(c)); // figure out if c is in vowels array
                if (vindex > -1) // vowels
                {
                    if (debug) Console.WriteLine(c + " is a vowel.");
                    values[1]++;
                }
                else // consonants
                {
                    if (debug) Console.WriteLine(c + " is a consonant.");
                    values[2]++;
                }

                if (Char.IsUpper(c)) // uppercase
                {
                    if (debug) Console.WriteLine(c + " is upper case.");
                    values[3]++;
                }
                else // lowercase
                {
                    if (debug) Console.WriteLine(c + " is lower case.");
                    values[4]++;
                }
            }

            return values;
        }
    }
}
