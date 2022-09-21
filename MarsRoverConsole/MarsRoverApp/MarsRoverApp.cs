using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverConsole.Models;

namespace MarsRoverConsole.MarsRoverApp
{
    public class MarsRoverApp
    {
        

        InstructionDecoder instructionDecoder = new InstructionDecoder();

        public MarsRoverApp()
        {
        }

        public string MarsManager(string input) 
        {
            return instructionDecoder.Decode(input);
        }
    }
}
