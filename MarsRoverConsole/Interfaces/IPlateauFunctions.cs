using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMissionConsole.Interfaces
{
    public interface IPlateauFunctions
    {
        public string GetPalteauTemperature();

        public bool AddObstacles(int x_Coordinate, int y_Coordinate);

        public bool RemoveObstacles(int x_Coordinate, int y_Coordinate);

        public string[,] DrawPlateau();
       
    }
}
