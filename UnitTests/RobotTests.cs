using Core.Enums;
using Model.Extension;
using Model.Grids.Factory;
using Model.Robots;
using NUnit.Framework;

namespace UnitTests
{

    public class RobotTests
    {
        IGridCreator gridCreator = new GridCreator();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SingleRobotMoveForward()
        {
            var grid = gridCreator.Create(2, 2);
            var direction = Direction.N.GetDirectionDescription();

            var robot = new Robot(0, 0, direction, new[] { Command.F }, grid);
            robot.Move();

            Assert.That(robot.PositionX, Is.EqualTo(0));
            Assert.That(robot.PositionY, Is.EqualTo(1));
            Assert.That(robot.Direction, Is.EqualTo(direction));
            Assert.IsFalse(robot.Fell);
        }

        [Test]
        public void SingleRobotFall()
        {
            var grid = gridCreator.Create(0, 0);
            var direction = Direction.N.GetDirectionDescription();

            var robot = new Robot(0, 0, direction, new[] { Command.F }, grid);
            robot.Move();

            Assert.That(robot.PositionX, Is.EqualTo(0));
            Assert.That(robot.PositionY, Is.EqualTo(0));
            Assert.That(robot.Direction, Is.EqualTo(direction));
            Assert.IsTrue(robot.Fell);
        }

        [Test]
        public void FirstRobotFallSecondNot()
        {
            var grid = gridCreator.Create(0, 0);
            var direction = Direction.N.GetDirectionDescription();

            var firstRobot = new Robot(0, 0, direction, new[] { Command.F }, grid);
            var secondRobot = new Robot(0, 0, direction, new[] { Command.F }, grid);
            firstRobot.Move();
            secondRobot.Move();

            Assert.That(firstRobot.PositionX, Is.EqualTo(0));
            Assert.That(firstRobot.PositionY, Is.EqualTo(0));
            Assert.That(firstRobot.Direction, Is.EqualTo(direction));
            Assert.IsTrue(firstRobot.Fell);


            Assert.That(secondRobot.PositionX, Is.EqualTo(0));
            Assert.That(secondRobot.PositionY, Is.EqualTo(0));
            Assert.That(secondRobot.Direction, Is.EqualTo(direction));
            Assert.IsFalse(secondRobot.Fell);
        }

        [Test]
        public void SecondRobotIgnoreFellTurnRight()
        {
            var grid = gridCreator.Create(0, 0);
            var direction = Direction.N.GetDirectionDescription();

            var firstRobot = new Robot(0, 0, direction, new[] { Command.F }, grid);
            var secondRobot = new Robot(0, 0, direction, new[] { Command.F, Command.R }, grid);
            firstRobot.Move();
            secondRobot.Move();

            Assert.That(firstRobot.PositionX, Is.EqualTo(0));
            Assert.That(firstRobot.PositionY, Is.EqualTo(0));
            Assert.That(firstRobot.Direction, Is.EqualTo(direction));
            Assert.IsTrue(firstRobot.Fell);


            Assert.That(secondRobot.PositionX, Is.EqualTo(0));
            Assert.That(secondRobot.PositionY, Is.EqualTo(0));
            Assert.That(secondRobot.Direction, Is.EqualTo(Direction.E.GetDirectionDescription()));
            Assert.IsFalse(secondRobot.Fell);
        }
    }
}
