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

        public string Decode(string instructions) 
        {
            string command = "";
            char [] singleInstructions = instructions.ToCharArray();

            foreach (char instruction in singleInstructions) 
            {
                Console.WriteLine(instruction);
               

                switch (instruction)
                {
                    case 'L': command += "Left ";
                        break;

                    case 'R': command += "Right ";
                        break ;

                    case 'M': command += "Move Forward ";
                        break;

                    default: command += "Unknown command ";
                        break;

                }


            }
            Console.WriteLine(command);
            return command;
            
        }
    }
}
