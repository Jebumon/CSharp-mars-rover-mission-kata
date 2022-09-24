// See https://aka.ms/new-console-template for more information
using MarsRoverConsole.MarsMissionApp;

Console.WriteLine("Hello, World!");

MarsMissionAppManager marsMissionAppManager = new MarsMissionAppManager(5, 5);
marsMissionAppManager.MarsManager("N", "LLRLRRL");
