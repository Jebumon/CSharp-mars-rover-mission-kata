using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsMissionConsole.Models;
using MarsRoverConsole.MarsMissionApp;

namespace MarsMissionConsole.MarsMissionApp

{
    public class DisplayManager
    {
        public CurrentCoordinate CurrentCoordinate { get; set; }
        public PlateauMap PlateauMap { get; set; }

        public DisplayManager(PlateauMap plateauMap, CurrentCoordinate currentCoordinate )
        {
            CurrentCoordinate = currentCoordinate;
            PlateauMap = plateauMap;
        }

        public void PrintDisplay() 
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int k = PlateauMap.Layout.GetLength(1)-1; k >= 0; k--)
                {
                    for (int j = 0; j< PlateauMap.Layout.GetLength(0); j++)
                    {
                        string tempElement = PlateauMap.Layout[j, k];
                        int a = PlateauMap.Layout.Length;

                    if(tempElement == "⏫"|| tempElement == "⏩" || tempElement == "⏪" || tempElement == "⏬") 
                    { 
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" " + tempElement + " ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    else 
                    { 
                        Console.Write(" " + tempElement + " "); 
                    }
                        
                    }
                    Console.WriteLine("\n");
                }
            Console.ForegroundColor = default;
        }
    }
}
