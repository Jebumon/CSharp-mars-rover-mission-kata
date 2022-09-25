using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMissionConsole.Models
{
    public class CurrentCoordinate
    {
        public int X_Coordinate { get; set; } = 0;
        public int Y_Coordinate { get; set; } = 0;

        public int X_MaxCoordinate { get; set; }
        public int Y_MaxCoordinate { get; set; }

        public string CurrentDirection { get; set; }

    }
}
