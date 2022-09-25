using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverConsole.Models
{
    public class InstructionDecoder
    {
        public InstructionDecoder()
        {
        }
        public string[] Decode(string instructions) 
        {
            string[] commandArray = new string[instructions.Length];
            char [] singleInstructions = instructions.ToCharArray();
            int i = 0;
            foreach (char instruction in singleInstructions) 
            {
                switch (instruction)
                {
                    case 'L':
                        commandArray[i++] = "Left";
                        break;

                    case 'R':
                        commandArray[i++] = "Right";
                        break ;

                    case 'M':
                        commandArray[i++] = "MoveForward";
                        break;

                    default:
                        commandArray[i++] = "UnknownCommand";
                        throw new ArgumentException(message: "Please enter valid command");
                }
            }
            /*foreach(string instruction in commandArray)
            {
                Console.WriteLine(instruction.ToString());
            }*/
            
            return commandArray;
            
        }
    }
}
