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
        //public string[,] PlateauLayout { get; set; }

        public VehicleManager(CurrentCoordinate currentCoordinate, PlateauMap plateauMap)
        {
            CurrentCoordinate = currentCoordinate;
            PlateauMap = plateauMap;
            
            //PlateauLayout = plateauLayout;
        }


        public virtual void MoveBackward(int x, int y)
        {
            throw new NotImplementedException();
        }

        public virtual void MoveForward(int x, int y)
        {
            throw new NotImplementedException();
        }

        public virtual void TurnLeft()
        {
            Console.WriteLine("RoverTurnLeft");
            //Console.WriteLine("Direction" + CurrentCoordinate.CurrentDirection);
            NewDirection = directionCalculator.CalculateDirection(CurrentCoordinate.CurrentDirection, "Left");
            Console.WriteLine("Direction" + CurrentCoordinate.CurrentDirection);
            //Console.WriteLine(NewDirection);
            CurrentCoordinate.CurrentDirection = NewDirection;
        }

        public virtual void TurnRight()
        {
            Console.WriteLine("RoverTurnRight");
            //Console.WriteLine("Direction" + CurrentCoordinate.CurrentDirection);
            NewDirection = directionCalculator.CalculateDirection(CurrentCoordinate.CurrentDirection, "Right");
            Console.WriteLine("Direction" + CurrentCoordinate.CurrentDirection);
            //Console.WriteLine(NewDirection);
            CurrentCoordinate.CurrentDirection = NewDirection;
        }
    }
}
