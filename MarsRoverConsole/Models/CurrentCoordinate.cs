using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMissionConsole.Models
{
    public class CurrentCoordinate
    {
        

        public int X_Coordinate { get; set; }
        public int Y_Coordinate { get; set; }

        public string CurrentDirection { get; set; }

     
/*
        public int Get_X_Coordinate() { return X_Coordinate; }
        public int Get_Y_Coordinate() { return Y_Coordinate; }

        public string Get_Direction() { return CurrentDirection; }

        public void SetCoordinate(int x, int y, string direction) 
        { 
            X_Coordinate = x;
            Y_Coordinate = y;
            CurrentDirection = direction;
        }*/
    }
}
