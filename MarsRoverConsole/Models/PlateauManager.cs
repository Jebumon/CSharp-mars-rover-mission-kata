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

        public string[,] Layout { get; set; }
        public PlateauLayout plateauLayout { get; set; }



        public PlateauManager(int max_x, int max_y)
        {
            Max_X_Coordinate = max_x;
            Max_Y_Coordinate = max_y;
            plateauLayout = new PlateauLayout(Max_X_Coordinate, Max_Y_Coordinate);
        }

        

        public bool AddObstacles(int x_Coordinate, int y_Coordinate)
        {
            throw new NotImplementedException();
        }

        public virtual string[,] DrawPlateau()
        {
            
            string[,] layout = plateauLayout.DrawLayout();
            Layout = layout;

            for (int j = 0; j < Max_X_Coordinate; j++)
            {
                for (int k = 0; k < Max_Y_Coordinate; k++)
                {
                    string tempElement = layout[j, k];
                    Console.Write(" " + tempElement + " ");
                }
                Console.WriteLine("\n");
            }

            return layout;

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
