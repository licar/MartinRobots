using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using ViewModel.Models;

namespace ConsoleApp
{
    public static class StringParseExtension
    {
        public static (int x, int y) GetGridCoordinates(this string input)
        {
            var coordinates = input.Split(' ').Select(c => int.Parse(c)).ToArray();
            if (coordinates.Length != 2) throw new Exception("Invalid coordinates input");
            return (coordinates[0], coordinates[1]);
        }

        public static InputRobotStateDto GetState(this string input)
        {
            var statements = input.Split(' ');
            if (statements.Length != 3) throw new Exception("Invalid positions input");

            return new InputRobotStateDto {
                PositionX = int.Parse(statements[0]),
                PositionY = int.Parse(statements[1]),
                Direction = (Direction)Enum.Parse(typeof(Direction), statements[2])
            };
        }

        public static Command[] GetCommands(this string input)
        {
            var commands = input.ToCharArray();
            return commands.Select(c => (Command)Enum.Parse(typeof(Command), c.ToString())).ToArray();
        }
    }
}
