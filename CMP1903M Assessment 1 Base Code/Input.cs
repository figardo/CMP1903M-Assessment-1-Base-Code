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
        public string manualTextInput()
        {
            text = Console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            if (File.Exists(fileName)) text = File.ReadAllText(fileName);
            return text;
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

                if (validOption && (option == 1 || option == 2)) return option;
                else Console.WriteLine("Invalid input, try again.");
            }
        }

    }
}
