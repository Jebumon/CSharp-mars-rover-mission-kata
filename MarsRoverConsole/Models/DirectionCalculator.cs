using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsMissionConsole.Models
{
    public class DirectionCalculator
    {

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
                Console.WriteLine("Please enter a valid direction");
                throw new ArgumentException("Please enter a valid direction");
            
        }
    }
}

