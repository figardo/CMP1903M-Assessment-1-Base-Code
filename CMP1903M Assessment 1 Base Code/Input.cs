using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        private string manualTextInput()
        {
            text = Console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        private string fileTextInput(string fileName)
        {
            if (File.Exists(fileName))
            {
                text = File.ReadAllText(fileName);
            }
            return text;
        }

        public string getSentences(int option)
        {
            string sentences = "";

            if (option == 1) // manual
            {
                Console.WriteLine("Enter each sentence, then end with an asterisk (*) once finished:");
                while (true)
                {
                    string sent = manualTextInput();
                    sentences += sent;

                    if (sent.EndsWith('*')) break;
                }
            }
            else if (option == 2) // file
            {
                Console.WriteLine("Enter the full path (or simply the filename if under bin/Debug/net6.0) of the txt file to analyse: ");
                //sentences = input.fileTextInput("CMP1903M Assessment 1 Test File.txt");
                while (true)
                {
                    string result = Console.ReadLine();
                    sentences = fileTextInput(result);
                    if (sentences == "nothing") // returning default probably bad
                    {
                        Console.WriteLine("Invalid filename, try again.");
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return sentences;
        }

        public int chooseOption()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1: Enter text via keyboard.");
            Console.WriteLine("2: Read text via file.");

            int option;
            while (true)
            {
                string result = Console.ReadLine();
                bool validOption = Int32.TryParse(result, out option);

                if (validOption && (option == 1 || option == 2))
                {
                    return option;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again.");
                }
            }
        }
    }
}
