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

        

        DirectionCalculator directionCalculator = new DirectionCalculator();

        RectangularPlateau rectangularPlateau = new RectangularPlateau();

        




        public MarsMissionAppManager(int xMaxCoordinate, int yMaxCoordinate)
        {
            X_MaxCoordinateOfPlateaue = xMaxCoordinate;
            Y_MaxCoordinateOfPlateaue = yMaxCoordinate;
        }

        public string MarsManager(string initialDirection, string inputInstructions) 
        {
            CurrentCoordinate currentCoordinate = new CurrentCoordinate();

            MarsRover marsRover = new MarsRover(currentCoordinate);
            

            currentCoordinate.CurrentDirection = initialDirection;

            Console.WriteLine("InitialDir"+initialDirection);

            Console.WriteLine("Cur"+currentCoordinate.CurrentDirection);

            String[] decodedInstructionsArray = instructionDecoder.Decode(inputInstructions);

            InstructionTransmitter instructionTransmitter = new InstructionTransmitter(currentCoordinate);

            instructionTransmitter.TransmitInstruction(decodedInstructionsArray);


            Console.WriteLine(currentCoordinate.CurrentDirection);

            //String decodedDirection = directionCalculator.CalculateDirection(InitialDirection, decodedInstructionsArray);

            return currentCoordinate.CurrentDirection;
        }
    }
}
