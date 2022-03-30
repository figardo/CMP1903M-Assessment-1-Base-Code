//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            // Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            // Create 'Input' object
            // Get either manually entered text, or text from a file
            Input input = new Input();
            int option = input.chooseOption();
            string sentences = input.getSentences(option);

            // Create an 'Analyse' object
            Analyse analyse = new Analyse();

            // Pass the text input to the 'analyseText' method
            // Receive a list of integers back
            parameters = analyse.analyseText(sentences);

            // Report the results of the analysis
            Report report = new Report();
            report.outputConsole(parameters);
            report.outputFile(parameters);
            report.longWords(sentences); // write a file containing words with >7 chars

            // TO ADD: Get the frequency of individual letters?
            // eh

        } 
    }
}
