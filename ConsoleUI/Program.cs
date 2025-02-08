Console.WriteLine("Welcome to the Goldy Gopher App by Tom Hoskins");
Console.WriteLine();

int lowerBound;
int upperBound;

while (true)
{
	Console.WriteLine("Enter the lower bound of the range of numbers to check:");
	if (!int.TryParse(Console.ReadLine(), out lowerBound))
	{
        Console.WriteLine("Please enter a valid integer value.");
        continue;
    }

    Console.WriteLine("Enter the upper bound of the range of numbers to check:");
    if (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.WriteLine("Please enter a valid integer value.");
        continue;
    }

    if (!(lowerBound < upperBound))
    {
        Console.WriteLine("The upper bound must be greater than the lower bound.");
        continue;
    }

    break;
}

for (int i = lowerBound; i <= upperBound; i++)
{
    var result = GoldyGopherLibrary.Utilities.GetGopherStringFromInt(i);
    Console.WriteLine($"{i}: {result}");
}
