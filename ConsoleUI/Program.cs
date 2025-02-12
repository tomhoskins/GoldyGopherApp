using ConsoleUI;
using System.Net.NetworkInformation;

Console.WriteLine("Welcome to the Goldy Gopher CSV App by Tom Hoskins");
Console.WriteLine();

int lowerBound;
int upperBound;
bool continueRunning = true;

do
{
    lowerBound = ConsoleHelpers.RequestIntegerInputWithValidation("Enter the lower bound: ");
    upperBound = ConsoleHelpers.RequestIntegerInputWithValidation("Enter the upper bound: ");

    if (!GoldyGopherLibrary.Utilities.ValidateBounds(lowerBound, upperBound))
    {
        ConsoleHelpers.WritePaddedLine("The lower bound must be less than the upper bound. Please try again.");
        continue;
    }

    var fileName = "GoldyGopherData.csv";
    var folderPath = ConsoleHelpers.RequestFolderPathForCsv();
    var filePath = ConsoleHelpers.GetUniqueFilePath(folderPath, fileName);

    var result = ConsoleHelpers.CreateGoldyGopherCsv(lowerBound, upperBound, filePath);

    if (result == "Success")
    {
        ConsoleHelpers.WritePaddedLine($"CSV file created and data written successfully at {filePath}.");
    }
    else
    {
        ConsoleHelpers.WritePaddedLine($"An error occurred: {result}");
    }
    continueRunning = ConsoleHelpers.DetermineIfRunningAgain();

} while (continueRunning);

Console.WriteLine("Program has finished executing. Press any key to close.");
Console.ReadLine();
