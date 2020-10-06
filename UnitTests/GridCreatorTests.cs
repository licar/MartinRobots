using Model.Grids;
using Model.Grids.Factory;
using NUnit.Framework;

namespace UnitTests
{
    public class GridCreatorTests 
    {
        IGridCreator gridCreator = new GridCreator();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateGridWithOneElement()
        {
            int x = 1, y = 1;          
            var grid = gridCreator.Create(x, y) as Grid
            Assert.That(grid.Cells.Length, Is.EqualTo(y + 1));
            Assert.That(grid.Cells[0].Length, Is.EqualTo(x + 1));
        }

        [Test]
        public void CreateMaximalGrid()
        {          
            int x = 50, y = 50;
            var grid = gridCreator.Create(x, y) as Grid;
            Assert.That(grid.Cells.Length, Is.EqualTo(y + 1));
            Assert.That(grid.Cells[0].Length, Is.EqualTo(x + 1));
        }

        [Test]
        public void CreateGridWithDifferentSizes()
        {
            int x = 30, y = 20;
            var grid = gridCreator.Create(x, y) as Grid;
            Assert.That(grid.Cells.Length, Is.EqualTo(y + 1));
            Assert.That(grid.Cells[0].Length, Is.EqualTo(x + 1));
        }
    }
}