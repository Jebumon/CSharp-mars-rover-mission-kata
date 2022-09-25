using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverConsole.Models;

namespace MarsMissionConsole.Models
{
    public class InstructionTransmitter
    {
        CurrentCoordinate CurrentCoordinate { get; set; }
        PlateauMap PlateauMap { get; set; }
        //string[,] PlateauLayout { get; set; }   
        

        //CurrentCoordinate currentCoordinate = new CurrentCoordinate();
        public InstructionTransmitter(CurrentCoordinate currentCoordinate, PlateauMap plateauMap)
        {
            CurrentCoordinate = currentCoordinate;
            PlateauMap = plateauMap;
            
            //PlateauLayout = plateauLayout;
            //MarsRover = new MarsRover();
        }

        public void TransmitInstruction(string[] decodedInstructionsArray) 
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
                        MarsRover.MoveForward(0,0);
                        break;
                }
            
            }
            
        }
    }
}
