namespace GoldyGopherLibrary
{
    public static class Utilities
    {
        public static string GetGopherStringFromInt(int input)
        {
            // Using the following definition for multiple:
            // B is a multiple of A if integer N exists such that B = A * N.

            // If input divided by X has a remainder of 0, then input is a multiple of X.

            // Per requirements:
            // If input is a multiple of 3 and 7, return "Goldy Gopher".
            // If input is a multiple of 3, return "Goldy".
            // If input is a multiple of 7, return "Gopher".
            // Otherwise, return the input as a string.

            bool isGoldy = input % 3 == 0;
            bool isGopher = input % 7 == 0;

            if (isGoldy && isGopher)
            {
                return "Goldy Gopher";
            }
            else if (isGoldy)
            {
                return "Goldy";
            }
            else if (isGopher)
            {
                return "Gopher";
            }
            else
            {
                return input.ToString();
            }
        }
    }
}
