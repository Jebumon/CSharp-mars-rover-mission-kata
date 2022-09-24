using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMissionConsole.Interfaces
{
    public interface IMovements
    {
        public void MoveForward(int x, int y);
        public void MoveBackward(int x, int y);
        public void TurnLeft();
        public void TurnRight();
    }
}
