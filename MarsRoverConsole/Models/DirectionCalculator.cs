using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMissionConsole.Models
{
    public class DirectionCalculator
    {
        //string[] directions = { "West", "North", "East", "South" };
        //string newDirection = "";

        public DirectionCalculator()
        {
        }

        public string CalculateDirection(string currentDirection, string command) 
        {
                if (currentDirection == "N")
                {
                    switch (command)
                    {
                        case "Left":
                            return "W";
                        case "Right":
                            return "E";

                    }
                }
                else if (currentDirection == "E")
                {
                    switch (command)
                    {
                        case "Left":
                            return "N";
                        case "Right":
                            return "S";

                    }
                }
                else if (currentDirection == "W")
                {
                    switch (command)
                    {
                        case "Left":
                            return "S";
                        case "Right":
                            return "N";

                    }
                }
                else if (currentDirection == "S")
                {
                    switch (command)
                    {
                        case "Left":
                            return "E";
                        case "Right":
                            return "W";
                    }
                }
            throw new ArgumentException("Please enter a valid direction");
            
            //return "Please enter a valid Direction";
        }
    }
}

