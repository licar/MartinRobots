using Core.Enums;
using Model.Cells;
using NUnit.Framework;

namespace UnitTests
{
    public class CellTests 
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckEmptyFallingDirections()
        {
            var cell = new Cell() as ICell;

            Assert.IsFalse(cell.IsFallingDirection(Direction.N));
            Assert.IsFalse(cell.IsFallingDirection(Direction.E));
            Assert.IsFalse(cell.IsFallingDirection(Direction.W));
            Assert.IsFalse(cell.IsFallingDirection(Direction.S));
        }

        [Test]
        public void SetFallingDirectionOnce()
        {
            var cell = new Cell() as ICell;

            cell.AddFallingDirection(Direction.N);

            Assert.IsTrue(cell.IsFallingDirection(Direction.N));
            Assert.IsFalse(cell.IsFallingDirection(Direction.W));
            Assert.IsFalse(cell.IsFallingDirection(Direction.E));
            Assert.IsFalse(cell.IsFallingDirection(Direction.S));
        }

        [Test]
        public void SetFallingDirectionTwice()
        {
            var cell = new Cell() as ICell;

            cell.AddFallingDirection(Direction.E);
            cell.AddFallingDirection(Direction.E);

            Assert.IsTrue(cell.IsFallingDirection(Direction.E));
            Assert.IsFalse(cell.IsFallingDirection(Direction.W));
            Assert.IsFalse(cell.IsFallingDirection(Direction.S));
            Assert.IsFalse(cell.IsFallingDirection(Direction.N));
        }
    }
}