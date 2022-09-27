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
                if(instruction == 'L'|| instruction == 'R'|| instruction == 'M') 
                {
                    switch (instruction)
                    {
                        case 'L':
                            commandArray[i++] = "Left";
                            break;

                        case 'R':
                            commandArray[i++] = "Right";
                            break;

                        case 'M':
                            commandArray[i++] = "MoveForward";
                            break;
  
                    }
                }
                else 
                {
                    Console.WriteLine("Invalid Movement Instruction");
                    throw new ArgumentException(message: "Please enter valid command");
                }
                

            }

            return commandArray;
            
        }
    }
}
