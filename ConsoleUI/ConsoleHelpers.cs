using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class ConsoleHelpers
    {
        // This method will request an integer input from the user and will continue to do so until a valid integer is entered.
        public static int RequestIntegerInputWithValidation(string message)
        {
            int output;
            bool isValid;
            do
            {
                Console.WriteLine(message);
                string? input = Console.ReadLine();
                isValid = int.TryParse(input, out output);
                if (!isValid)
                {
                    WritePaddedLine($"Please enter a value between {int.MinValue} and {int.MaxValue}");
                }
            } while (!isValid);
            return output;
        }

        // This method will request a folder path from the user and will continue to do so until a valid path is entered.
        public static string RequestFolderPathForCsv()
        {
            string output;
            bool isValid;
            do
            {
                Console.WriteLine("Please enter the folder path where you would like to store the CSV file.");
                string? folderPath = Console.ReadLine()?? "";
                isValid = Path.Exists(folderPath);
                if (!isValid)
                {
                    WritePaddedLine($"{folderPath} does not exist. Please try again.");
                }
                output = folderPath;
            } while (!isValid);
            return output;
        }

        // This method will return a unique file path by appending a number to the file name if the file already exists.
        public static string GetUniqueFilePath(string folderPath, string fileName)
        {
            var filePath = $"{folderPath}\\{fileName}";
            var filePathWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            var counter = 1;
            while (File.Exists(filePath))
            {
                filePath = Path.Combine(folderPath, $"{filePathWithoutExtension}_{counter}.csv");
                counter++;
            }
            return filePath;
        }

        // This method will create a CSV file with the Goldy Gopher data.
        public static string CreateGoldyGopherCsv(int lowerBound, int upperBound, string filePath)
        {
            try
            {
                // Create the StreamWriter object
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the header row
                    writer.WriteLine("GopherString,");
                    for (int i = lowerBound; i <= upperBound; i++)
                    {
                        // Write the data rows delimitted by a comma
                        writer.WriteLine($"{GoldyGopherLibrary.Utilities.GetGopherStringFromInt(i)},");
                    }
                }
                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // This method will determine if the user wants to run the program again.
        public static bool DetermineIfRunningAgain()
        {
            Console.WriteLine("Enter 'yes' to run again:");
            var input = Console.ReadLine();
            return input?.ToLower() == "yes";
        }

        // This method will write a message to the console with a new line before and after.
        public static void WritePaddedLine(string message)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
