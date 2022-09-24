using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsMissionConsole.Models;

namespace MarsRoverConsole.Models
{
    public class MarsRover : VehicleManager
    {
        public MarsRover(CurrentCoordinate currentCoordinate) : base(currentCoordinate)
        {
        }

        public string Rover() 
        {

            return "Rover";
        }
    }
}
