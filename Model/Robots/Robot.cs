using Core.Enums;
using Model.Extension;
using Model.Grids;
using DirectionDescription = System.Collections.Generic.KeyValuePair<(int x, int y), Core.Enums.Direction>;

namespace Model.Robots
{
    public class Robot : IRobot
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public DirectionDescription Direction { get; private set; }
        public bool Fell { get; private set; } = false;
        private readonly Command[] commands;
        private readonly IGrid grid;

        public Robot(int posX, int posY, DirectionDescription direction, Command[] commands, IGrid grid)
        {
            PositionX = posX;
            PositionY = posY;
            Direction = direction;
            this.commands = commands;
            this.grid = grid;
        }
        public void Move()
        {
            foreach (var command in commands)
            {
                if (command != Command.F)
                {
                    Direction = Direction.Rotate(command);
                    continue;
                }

                if (grid.IsFallingDirection(PositionY, PositionX, Direction.Value)) 
                    continue;

                var newPosition = GetMoveForwardPosition();
                if (grid.IsOutOfBounds(newPosition.y, newPosition.x))
                {
                    Fell = true;
                    grid.AddFallingDirection(PositionY, PositionX, Direction.Value);
                    return;
                }

                PositionX = newPosition.x;
                PositionY = newPosition.y;
            }
        }

        private (int x, int y) GetMoveForwardPosition()
        {
            return (PositionX + Direction.Key.x, PositionY + Direction.Key.y);
        }
    }
}
