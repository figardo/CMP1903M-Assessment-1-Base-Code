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
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input input = new Input();

            int option = input.chooseOption();

            string sentences = "";

            if (option == 1)
            {
                Console.WriteLine("Enter each sentence, then end with an asterisk (*) once finished:");
                while (true)
                {
                    string sent = input.manualTextInput();
                    sentences += sent;

                    if (sent.EndsWith('*')) break;
                }
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter the full path (or simply the filename if under bin/Debug/net6.0) of the txt file to analyse: ");
                //sentences = input.fileTextInput("CMP1903M Assessment 1 Test File.txt");
                while (true)
                {
                    string result = Console.ReadLine();
                    sentences = input.fileTextInput(result);
                    if (sentences == "nothing") Console.WriteLine("Invalid filename, try again.");
                    else break;
                }
            }

            LongWords(sentences);

            //Create an 'Analyse' object
            Analyse analyse = new Analyse();

            //Pass the text input to the 'analyseText' method
            //Receive a list of integers back
            parameters = analyse.analyseText(sentences);

            //Report the results of the analysis
            Report report = new Report();
            report.outputConsole(parameters);
            report.outputFile(parameters);

            //TO ADD: Get the frequency of individual letters?


        }
        
        static void LongWords(string sentences)
        {
            string[] temp = sentences.Split('*');
            string[] words = temp[0].Split(' ');
            List<string> longwords = new List<string>();

            foreach (string word in words)
            {
                if (word.Length > 7)
                {
                    longwords.Add(word);
                }
            }
            string[] final = longwords.ToArray();
            File.WriteAllLines("long_words.txt", final);
        }
    
    }
}
