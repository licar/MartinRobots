using Core.Enums;
using Model.Extension;
using NUnit.Framework;

namespace UnitTests
{
    public class DirectionTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetDirectionDiscriptionByDirection()
        {
            var direction = Direction.N;
            var directionDiscription = direction.GetDirectionDescription();
            Assert.AreEqual(directionDiscription.Value, direction);
        }

        [Test]
        public void RotateNorthToLeft()
        {
            var direction = Direction.N;
            var directionDiscription = direction.GetDirectionDescription();
            var newDirection = directionDiscription.Rotate(Command.L);
            Assert.AreEqual(newDirection.Value, Direction.W);
        }

        [Test]
        public void RotateNorthToRight()
        {
            var direction = Direction.N;
            var directionDiscription = direction.GetDirectionDescription();
            var newDirection = directionDiscription.Rotate(Command.R);
            Assert.AreEqual(newDirection.Value, Direction.E);
        }

        [Test]
        public void RotateEastToRight()
        {
            var direction = Direction.E;
            var directionDiscription = direction.GetDirectionDescription();
            var newDirection = directionDiscription.Rotate(Command.R);
            Assert.AreEqual(newDirection.Value, Direction.S);
        }

        [Test]
        public void RotateForwardCommand()
        {
            var direction = Direction.N;
            var directionDiscription = direction.GetDirectionDescription();
            var newDirection = directionDiscription.Rotate(Command.F);
            Assert.AreEqual(newDirection.Value, Direction.N);
        }
    }
}
