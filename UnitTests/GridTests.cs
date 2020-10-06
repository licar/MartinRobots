using Core.Enums;
using Model.Grids;
using Model.Grids.Factory;
using NUnit.Framework;

namespace UnitTests
{
    public class GridTests 
    {
        IGridCreator gridCreator = new GridCreator();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AllCellsNotScent()
        {
            int x = 10, y = 10;

            var grid = gridCreator.Create(x, y);

            for (var rowIdx = 0; rowIdx < y; ++rowIdx)
            {
                for (var cellIdx = 0; cellIdx < y; ++cellIdx)
                {
                    Assert.IsFalse(grid.IsFallingDirection(rowIdx, cellIdx, Direction.N));
                    Assert.IsFalse(grid.IsFallingDirection(rowIdx, cellIdx, Direction.E));
                    Assert.IsFalse(grid.IsFallingDirection(rowIdx, cellIdx, Direction.S));
                    Assert.IsFalse(grid.IsFallingDirection(rowIdx, cellIdx, Direction.W));
                }
            } 
        }

        [Test]
        public void OneCellScent()
        {
            int xSize = 10, ySize = 10;
            int scentX = 0, scentY = 0;
            var scentDirection = Direction.N;

            var grid = gridCreator.Create(xSize, ySize);
            grid.AddFallingDirection(scentY, scentX, scentDirection);

            for (var y = 0; y < ySize; ++y)
            {
                for (var x = 0; x < scentX; ++x)
                {
                    if (x == scentX && y == scentY) 
                        Assert.IsTrue(grid.IsFallingDirection(y, x, Direction.N));
                    else Assert.IsFalse(grid.IsFallingDirection(y, x, Direction.N));
                    
                    Assert.IsFalse(grid.IsFallingDirection(y, x, Direction.E));
                    Assert.IsFalse(grid.IsFallingDirection(y, x, Direction.S));
                    Assert.IsFalse(grid.IsFallingDirection(y, x, Direction.W));
                }
            }
        }


        [Test]
        public void CheckInsideOfGrid()
        {
            int xSize = 10, ySize = 5;

            var grid = gridCreator.Create(xSize, ySize) ;
            Assert.IsFalse(grid.IsOutOfBounds(0, 0));
            Assert.IsTrue(grid.IsOutOfBounds(-1, 0));
            Assert.IsTrue(grid.IsOutOfBounds(0, -1));

            Assert.IsTrue(grid.IsOutOfBounds(ySize + 1, xSize + 1));
            Assert.IsFalse(grid.IsOutOfBounds(ySize, xSize));
            Assert.IsFalse(grid.IsOutOfBounds(ySize, xSize));
        }
    }
}