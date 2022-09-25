using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverConsole.Models;

namespace MarsMissionConsole.Models
{
    public class InstructionTransmitter
    {   CurrentCoordinate CurrentCoordinate { get; set; }
        PlateauMap PlateauMap { get; set; }
        RoverCoordinateList RoverCoordinateList { get; set; }

        public InstructionTransmitter(CurrentCoordinate currentCoordinate, PlateauMap plateauMap, RoverCoordinateList roverCoordinateList)
        {
            CurrentCoordinate = currentCoordinate;
            PlateauMap = plateauMap;
            RoverCoordinateList = roverCoordinateList;
            
        }

        public RoverCoordinateList TransmitInstruction(string[] decodedInstructionsArray) 
        {
            MarsRover MarsRover = new MarsRover(CurrentCoordinate, PlateauMap);
            
            foreach (var instruction in decodedInstructionsArray) 
            {
                switch (instruction) 
                {
                    case "Left":
                        MarsRover.TurnLeft();
                        break;

                    case "Right":
                        MarsRover.TurnRight();
                        break;

                    case "MoveForward":
                        CurrentCoordinate coordinate = MarsRover.MoveForward(0,0);
                        Console.WriteLine("Rover Route coordinates: "+coordinate.X_Coordinate+ " "+ coordinate.Y_Coordinate+" "+ coordinate.CurrentDirection);
                        RoverCoordinateList.currentCoordinateList.Add(coordinate);

                        //Work in progress
                        /*foreach(var a in RoverCoordinateList.currentCoordinateList) 
                        {
                            Console.WriteLine("RCL : "+a.X_Coordinate+ " " + a.Y_Coordinate); 
                        
                        }*/

                        break;
                }
                
            }
            return RoverCoordinateList;
        }
    }
}
