# GoldyGopherApp

## Overview
The purpose of this application is to print/display the numbers in a loop starting at a user provided lower bound and ending at a user provided upper bound. When printing the numbers in the loop, replace multiples of 3 with "Goldy", mutliples of 7 with "Gopher", and multiples of both with "Goldy Gopher".

### GoldyGopherUI (WPF GUI)
The purpose of this project is to provide the user with a means to enter bounds and visualize the results using a GUI. The bounds must be valid integers and the maximum absolute value of the difference between lower bound and upper bound is 10,000. Larger data sets can be acquired by running the console app which creates a CSV file with the output.

### ConsoleUI
The purpose of this project is to run the application logic on a large dataset and store the output in a CSV file.

## Dependencies

### General Dependencies
- Visual Studio 2022
- .NET Core 8.0.11 SDK (Included in Visual Studio 2022(17.11.6) or available [here](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)) or newer
- [git](https://git-scm.com/downloads)

## Building and Running the Application

### Prerequisites
- Ensure you have all dependencies installed.

### Steps
1. Clone the repository to a local folder (referred to as CLONE_LOCATION below):
   ```bash
   git clone https://github.com/tomhoskins/GoldyGopherApp.git
2. Open GoldyGopherApp.sln in Visual Studio
3. Set the Solution Configuration to Release
4. Build the solution (Ctrl + Shift + B)
5. Run the desired application
   - GoldyGopherUI: CLONE_LOCATION\GoldyGopherApp\GoldyGopherUI\bin\Release\net8.0-windows\GoldyGopherUI
   - ConsoleUI: CLONE_LOCATION\GoldyGopherApp\ConsoleUI\bin\Release\net8.0\ConsoleUI
