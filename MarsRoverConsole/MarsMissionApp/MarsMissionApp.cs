using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverConsole.Models;

namespace MarsRoverConsole.MarsMissionApp
{
    public class MarsMissionApp
    {
        

        InstructionDecoder instructionDecoder = new InstructionDecoder();

        public MarsMissionApp()
        {
        }

        public string MarsManager(string input) 
        {
            return instructionDecoder.Decode(input);
        }
    }
}
