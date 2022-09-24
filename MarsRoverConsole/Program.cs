// See https://aka.ms/new-console-template for more information
using MarsRoverConsole.MarsMissionApp;
using MarsMissionConsole.Models;

Console.WriteLine("Hello, World");

Console.WriteLine("Enter maximum X coordinate of Plateau");
int Max_X_Coordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter maximum Y coordinate of Plateau");
int Max_Y_Coordinate = Convert.ToInt32(Console.ReadLine());

MarsMissionAppManager marsMissionAppManager = new MarsMissionAppManager(Max_X_Coordinate, Max_Y_Coordinate);

Console.WriteLine("Enter X coordinate of Rover");
int Rover_X_Coordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Y coordinate of Rover");
int Rover_Y_Coordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter initial direction of Rover");
string RoverInitialDirection = Console.ReadLine();
Console.WriteLine("Enter some Instructions for Rover");
string RoverInstructions = Console.ReadLine();


Console.WriteLine(marsMissionAppManager.MarsManager(Rover_X_Coordinate, Rover_Y_Coordinate, RoverInitialDirection, RoverInstructions));