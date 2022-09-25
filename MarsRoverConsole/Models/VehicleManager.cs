using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsMissionConsole.Interfaces;

namespace MarsMissionConsole.Models
{
    public abstract class VehicleManager : DirectionCalculator,  IMovements
    {
        public string NewDirection = "";
        DirectionCalculator directionCalculator = new DirectionCalculator();
        CurrentCoordinate CurrentCoordinate { get; set; }
        PlateauMap PlateauMap { get; set; }

        public VehicleManager(CurrentCoordinate currentCoordinate, PlateauMap plateauMap)
        {
            CurrentCoordinate = currentCoordinate;
            PlateauMap = plateauMap;
        }


        public virtual void MoveBackward(int x, int y)
        {
            throw new NotImplementedException();
        }

        public virtual CurrentCoordinate MoveForward(int x, int y)
        {
            switch(CurrentCoordinate.CurrentDirection)
            {
                case "N":
                    CurrentCoordinate.Y_Coordinate++;
                    break;
                case "E":
                    CurrentCoordinate.X_Coordinate++;
                    break;
                case "W":
                    CurrentCoordinate.X_Coordinate--;
                    break;
                case "S":
                    CurrentCoordinate.Y_Coordinate--;
                    break;
            }
            return CurrentCoordinate;
        }

        public virtual void TurnLeft()
        {
            Console.WriteLine("Rover Turn Left ◀️");
            NewDirection = directionCalculator.CalculateDirection(CurrentCoordinate.CurrentDirection, "Left");
            CurrentCoordinate.CurrentDirection = NewDirection;
        }
        
        public virtual void TurnRight()
        {
            Console.WriteLine("Rover Turn Right ▶️");
            NewDirection = directionCalculator.CalculateDirection(CurrentCoordinate.CurrentDirection, "Right");
            CurrentCoordinate.CurrentDirection = NewDirection;
        }
    }
}
