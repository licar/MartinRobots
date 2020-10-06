using Core.Enums;
using Model.Cells;

namespace Model.Grids
{
    public class Grid : IGrid
    {
        public ICell[][] Cells { get; }
        public Grid(ICell[][] cells)
        {
            Cells = cells;
        }
        public bool IsFallingDirection(int posY, int posX, Direction direction)
        {
            return Cells[posY][posX].IsFallingDirection(direction);
        }

        public void AddFallingDirection(int posY, int posX, Direction direction)
        {
            Cells[posY][posX].AddFallingDirection(direction);
        }

        public bool IsOutOfBounds(int posY, int posX)
        {
            return posX < 0 || posX >= Cells[0].Length  || posY < 0 || posY >= Cells.Length;
        }
    }
}
