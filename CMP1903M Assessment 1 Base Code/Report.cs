using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        public void outputConsole(List<int> parameters)
        {
            Console.WriteLine("Number of sentences entered = " + parameters[0]);
            Console.WriteLine("Number of vowels = " + parameters[1]);
            Console.WriteLine("Number of consonants = " + parameters[2]);
            Console.WriteLine("Number of upper case letters = " + parameters[3]);
            Console.WriteLine("Number of lower case letters = " + parameters[4]);
        }

        public async void outputFile(List<int> parameters)
        {
            string[] lines =
            {
                "Number of sentences entered = " + parameters[0],
                "Number of vowels = " + parameters[1],
                "Number of consonants = " + parameters[2],
                "Number of upper case letters = " + parameters[3],
                "Number of lower case letters = " + parameters[4]
            };

            await File.WriteAllLinesAsync("output.txt", lines);
        }
    }
}
