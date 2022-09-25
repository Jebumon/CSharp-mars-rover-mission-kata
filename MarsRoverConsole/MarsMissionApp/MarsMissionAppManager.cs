using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverConsole.Models;
using MarsMissionConsole.Models;

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
            CurrentCoordinate currentCoordinate = new CurrentCoordinate();
            currentCoordinate.CurrentDirection = initialDirection;
            currentCoordinate.X_Coordinate = Rover_X_Coordinate;
            currentCoordinate.Y_Coordinate = Rover_Y_Coordinate;

            PlateauMap plateauMap = new PlateauMap();

            RectangularPlateau plateau = new RectangularPlateau(X_MaxCoordinateOfPlateaue,Y_MaxCoordinateOfPlateaue, plateauMap);
            plateau.DrawPlateau();
            Console.WriteLine("----------------Plateau Layout----------------");
            plateau.PrintPlateau();
            plateauMap.Layout[currentCoordinate.X_Coordinate, currentCoordinate.Y_Coordinate] = "^";
            Console.WriteLine("----------------Plateau Layout----------------");
            plateau.PrintPlateau();
            String[] decodedInstructionsArray = instructionDecoder.Decode(inputInstructions);

            InstructionTransmitter instructionTransmitter = new InstructionTransmitter(currentCoordinate, plateauMap);

            instructionTransmitter.TransmitInstruction(decodedInstructionsArray);

            

          
            return currentCoordinate.CurrentDirection;
        }
    }
}
