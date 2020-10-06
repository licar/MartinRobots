using Core.Enums;
using System.Collections.Generic;

namespace Model.Cells
{
    public class Cell : ICell
    {
        private readonly HashSet<Direction> fallingDirections = new HashSet<Direction>();
        public bool IsFallingDirection(Direction direction)
        {
            return fallingDirections.Contains(direction);
        }

        public void AddFallingDirection(Direction direction)
        {
            if (!fallingDirections.Contains(direction))
                fallingDirections.Add(direction);
        }
    }
}
