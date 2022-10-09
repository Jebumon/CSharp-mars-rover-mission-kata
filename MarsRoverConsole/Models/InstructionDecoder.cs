using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsMissionConsole.MarsMissionApp;

namespace MarsRoverConsole.Models
{
    public class InstructionDecoder
    {
        RunningLoop runningLoop = new RunningLoop();
        public InstructionDecoder()
        {
        }
        public string[] Decode(string instructions)
        {
            string[] commandArray = new string[instructions.Length];
            char[] singleInstructions = instructions.ToCharArray();
            int i = 0;

            try
            {
                foreach (char instruction in singleInstructions)
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
                        default:
                            Console.WriteLine("Invalid Movement Instruction switch");
                            throw new ArgumentException();     
                    }
                }
                return commandArray;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new ArgumentException(message: "Please enter valid command");
            }
        }
    }
}
