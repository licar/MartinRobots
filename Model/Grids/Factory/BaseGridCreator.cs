using Model.Cells;
using System.Linq;

namespace Model.Grids.Factory
{
    public class GridCreator : IGridCreator
    {
        protected const int START_IDX = 0;
        public IGrid Create(int x, int y) {
            var cells = Enumerable.Range(START_IDX, y + 1)
                .Select(_ => Enumerable.Range(START_IDX, x + 1)
                .Select(__ => new Cell() as ICell).ToArray()).ToArray();
            return new Grid(cells);
        }
    }
}
