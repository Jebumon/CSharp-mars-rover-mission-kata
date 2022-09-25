using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsMissionConsole.Models;
using MarsRoverConsole.MarsMissionApp;

namespace MarsMissionConsole.MarsMissionApp

{
    public class DisplayManager
    {
        public CurrentCoordinate CurrentCoordinate { get; set; }
        public RoverCoordinateList RoverCoordinateList { get; set; }
        public PlateauMap PlateauMap { get; set; }

        public DisplayManager(RoverCoordinateList roverCoordinateList, PlateauMap plateauMap, CurrentCoordinate currentCoordinate )
        {
            CurrentCoordinate = currentCoordinate;
            RoverCoordinateList = roverCoordinateList;
            PlateauMap = plateauMap;
        }

        public void UpdateDisplay() 
        {
            foreach(var roverCoordinate in RoverCoordinateList.currentCoordinateList) 
            {
                //Console.WriteLine("X: " + roverCoordinate.X_Coordinate.ToString() + " Y : " + roverCoordinate.Y_Coordinate.ToString());
                PlateauMap.Layout[roverCoordinate.X_Coordinate, roverCoordinate.Y_Coordinate] = "⏫";
            }
        }

        public void PrintDisplay() 
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int k = PlateauMap.Layout.GetLength(1)-1; k >= 0; k--)
                {
                    for (int j = 0; j< PlateauMap.Layout.GetLength(0); j++)
                    {
                        string tempElement = PlateauMap.Layout[j, k];
                        int a = PlateauMap.Layout.Length;
                        Console.Write(" " + tempElement + " ");
                    }
                    Console.WriteLine("\n");
                }
            Console.ForegroundColor = default;
        }
    }
}
