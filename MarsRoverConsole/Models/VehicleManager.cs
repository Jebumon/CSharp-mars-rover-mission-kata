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

        public virtual CurrentCoordinate MoveForward()
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
            RoverRouteUpdate(CurrentCoordinate.X_Coordinate, CurrentCoordinate.Y_Coordinate, CurrentCoordinate.CurrentDirection);
            Console.WriteLine("Rover route coordinates : "+ CurrentCoordinate.X_Coordinate+" "+ CurrentCoordinate.Y_Coordinate+" "+CurrentCoordinate.CurrentDirection);

            return CurrentCoordinate;
        }

        public virtual void RoverRouteUpdate(int x_Coordinate, int y_Coordinate, string direction) 
        {
            string roverImage = "";
            switch (direction)
            {
                case "N":
                    roverImage = "⏫";
                    break;
                case "E":
                    roverImage = "⏩";
                    break;
                case "W":
                    roverImage = "⏪";
                    break;
                case "S":
                    roverImage = "⏬";
                    break;
            }
            try
            {

                PlateauMap.Layout[x_Coordinate, y_Coordinate] = roverImage;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new ArgumentException(message: "Can't place rover outside the Plateau");
            }
        }

        public virtual void TurnLeft()
        {
            Console.WriteLine("Rover Turn Left  ◀️");
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
