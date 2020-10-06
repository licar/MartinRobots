using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using DirectionDescription = System.Collections.Generic.KeyValuePair<(int x, int y), Core.Enums.Direction>;

namespace Model.Extension
{
    public static class DirectionExtension
    {
        private const double ANGEL_RADIANS = 1.57079632679;
        private static Dictionary<(int x, int y), Direction> directions;

        static DirectionExtension()
        {
            directions = new Dictionary<(int x, int y), Direction>
            {
                { (0, 1), Direction.N  },
                { (0, -1), Direction.S },
                { (1, 0), Direction.E },
                { (-1, 0), Direction.W }
            };
        }

        public static DirectionDescription GetDirectionDescription(this Direction direction)
        {
            return directions.First(d => d.Value == direction);
        }

        public static DirectionDescription Rotate(this DirectionDescription direction, Command command)
        {
            if (command == Command.F) return direction;

            var sign = command == Command.R ? -1 : 1;
            var angle = sign * ANGEL_RADIANS;

            var posX = (int)Math.Round(direction.Key.x * Math.Cos(angle) - direction.Key.y * Math.Sin(angle));
            var posY = (int)Math.Round(direction.Key.x * Math.Sin(angle) - direction.Key.y * Math.Cos(angle));

            var newDirection = directions[(posX, posY)];
            return new DirectionDescription((posX, posY), newDirection);
        }
    }
}
