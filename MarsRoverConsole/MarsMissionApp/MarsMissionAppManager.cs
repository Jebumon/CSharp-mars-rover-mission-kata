using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverConsole.Models;
using MarsMissionConsole.Models;
using MarsMissionConsole.MarsMissionApp;

namespace MarsRoverConsole.MarsMissionApp
{
    public class MarsMissionAppManager
    {
        public string InitialDirection = "";
        public int X_MaxCoordinateOfPlateaue { get; private set; }
        public int Y_MaxCoordinateOfPlateaue { get; private set; }

        InstructionDecoder instructionDecoder = new InstructionDecoder();

        public MarsMissionAppManager(int xMaxCoordinate, int yMaxCoordinate)
        {
            X_MaxCoordinateOfPlateaue = xMaxCoordinate;
            Y_MaxCoordinateOfPlateaue = yMaxCoordinate;
        }

        public string MarsManager(int Rover_X_Coordinate, int Rover_Y_Coordinate, string initialDirection, string inputInstructions) 
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            CurrentCoordinate currentCoordinate = new CurrentCoordinate();
            currentCoordinate.CurrentDirection = initialDirection;
            currentCoordinate.X_Coordinate = Rover_X_Coordinate;
            currentCoordinate.Y_Coordinate = Rover_Y_Coordinate;
            currentCoordinate.X_MaxCoordinate = X_MaxCoordinateOfPlateaue;
            currentCoordinate.Y_MaxCoordinate = Y_MaxCoordinateOfPlateaue;

            PlateauMap plateauMap = new PlateauMap();
            RoverCoordinateList roverCoordinateList = new RoverCoordinateList();

            DisplayManager displayManager = new DisplayManager(roverCoordinateList, plateauMap, currentCoordinate);
            displayManager.UpdateDisplay();

            String[] decodedInstructionsArray = instructionDecoder.Decode(inputInstructions);
            
            InstructionTransmitter instructionTransmitter = new InstructionTransmitter(currentCoordinate, plateauMap, roverCoordinateList);

            roverCoordinateList = instructionTransmitter.TransmitInstruction(decodedInstructionsArray);

            /*foreach(var instruction in roverCoordinateList.currentCoordinateList) 
            {
                Console.WriteLine("MMM : " +instruction.X_Coordinate + " " + instruction.Y_Coordinate);
            }*/

            RectangularPlateau plateau = new RectangularPlateau(X_MaxCoordinateOfPlateaue,Y_MaxCoordinateOfPlateaue, plateauMap);
            plateau.DrawPlateau();

            Console.WriteLine("\n---------------------Plateau Layout--------------------\n");
            displayManager.UpdateDisplay();
            displayManager.PrintDisplay();

            string output = currentCoordinate.X_Coordinate.ToString() +" "+ currentCoordinate.Y_Coordinate.ToString() +" "+ currentCoordinate.CurrentDirection;
            return output;
        }
    }
}
