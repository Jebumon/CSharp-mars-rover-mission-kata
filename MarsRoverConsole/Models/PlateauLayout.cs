using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMissionConsole.Models
{
    public class PlateauLayout
    {
        PlateauMap PlateauMap { get; set; }
        public int Max_X { get; private set; }
        public int Max_Y { get; private set; }

        public PlateauLayout(int max_X, int max_Y, PlateauMap plateauMap)
        {
            Max_X = max_X;
            Max_Y = max_Y;  
            PlateauMap = plateauMap;
        }
        public PlateauMap DrawLayout() 
        {
            string[,] layout = new string[Max_X, Max_Y];

            for(int j = 0; j<Max_X; j++) 
            {
                for(int k = 0; k<Max_Y; k++) 
                {
                    layout[j,k] = "🟨";
                }
            }

            PlateauMap.Layout = layout;
            return PlateauMap;
        
        }
    }
}
