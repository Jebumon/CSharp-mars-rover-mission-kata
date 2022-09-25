using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsMissionConsole.Models;


namespace MarsMissionConsole.Models
{
    public class RoverCoordinateList
    {
       public List<CurrentCoordinate> currentCoordinateList { get; set; } = new List<CurrentCoordinate>();
    }
}
