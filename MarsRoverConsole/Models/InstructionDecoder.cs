using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverConsole.Models
{
    public class InstructionDecoder
    {
        public string Decode(string instruction) 
        {
            switch (instruction) 
            {
                case "L": return "Left";

                case "R": return "Right";

                case "M": return "Move Forward";

                default: return "Unknown command";

            }
        }
    }
}
