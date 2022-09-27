// See https://aka.ms/new-console-template for more information
using MarsRoverConsole.MarsMissionApp;
using MarsMissionConsole.Models;
while (true)
{
    Console.WriteLine("******************** Mission to Mars **********************");

    Console.WriteLine("Enter maximum X coordinate of Plateau");
    int Max_X_Coordinate = Convert.ToInt32(Console.ReadLine()) + 1;
    Console.WriteLine("Enter maximum Y coordinate of Plateau");
    int Max_Y_Coordinate = Convert.ToInt32(Console.ReadLine()) + 1;

    MarsMissionAppManager marsMissionAppManager = new MarsMissionAppManager(Max_X_Coordinate, Max_Y_Coordinate);

    Console.WriteLine("Enter X coordinate of Rover");
    int Rover_X_Coordinate = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Y coordinate of Rover");
    int Rover_Y_Coordinate = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter initial direction of Rover");
    string RoverInitialDirection = Console.ReadLine().ToUpper();
    Console.WriteLine("Enter some Instructions for Rover");
    string RoverInstructions = Console.ReadLine().ToUpper();

    Console.WriteLine("\n********************** Rover data from Mars *************************\n");
    string RoverDestination = marsMissionAppManager.MarsManager(Rover_X_Coordinate, Rover_Y_Coordinate, RoverInitialDirection, RoverInstructions);


    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Rover initial position : " + Rover_X_Coordinate.ToString() + " " + Rover_Y_Coordinate.ToString() + " " + RoverInitialDirection);
    Console.WriteLine("Input instructions     : " + RoverInstructions);
    Console.WriteLine("Rover final position   : " + RoverDestination);

    Console.ForegroundColor = ConsoleColor.White;
}