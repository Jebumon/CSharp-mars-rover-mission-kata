using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsMissionConsole.Models;

namespace MarsMissionConsole.Interfaces
{
    public interface IMovements
    {
        public CurrentCoordinate MoveForward();
        public void MoveBackward(int x, int y);
        public void RoverRouteUpdate(int x, int y, string direction);
        public void TurnLeft();
        public void TurnRight();
    }
}
