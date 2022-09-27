using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsMissionConsole.Interfaces;
using MarsMissionConsole.Models;

namespace MarsRoverConsole.Models
{
    public abstract class PlateauManager : IPlateauFunctions
    {
        public int Max_X_Coordinate { get; set; }
        public int Max_Y_Coordinate { get; set; }
        PlateauLayout plateauLayout { get; set; }
        PlateauMap PlateauMap { get; set; }
        public PlateauManager(int max_x, int max_y, PlateauMap plateauMap)
        {
            Max_X_Coordinate = max_x;
            Max_Y_Coordinate = max_y;
            PlateauMap = plateauMap;
            plateauLayout = new PlateauLayout(Max_X_Coordinate, Max_Y_Coordinate, PlateauMap);
        }

        public bool AddObstacles(int x_Coordinate, int y_Coordinate)
        {
            throw new NotImplementedException();
        }

        public virtual PlateauMap DrawPlateau()
        {
            
            PlateauMap = plateauLayout.DrawLayout();
            return PlateauMap;
        }

        public void PrintPlateau() 
        {
            for (int j = Max_X_Coordinate-1; j >= 0 ; j--)
            {
                for (int k = 0; k < Max_Y_Coordinate; k++)
                {
                    string tempElement = PlateauMap.Layout[j, k];
                    Console.Write(" " + tempElement + " ");
                }
                Console.WriteLine("\n");
            }
        }

        

        public string GetPalteauTemperature() 
        {
            return "";
        }

        public bool RemoveObstacles(int x_Coordinate, int y_Coordinate)
        {
            throw new NotImplementedException();
        }
    }
}
