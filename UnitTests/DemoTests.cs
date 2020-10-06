using Core.Enums;
using Model.Coordinators;
using Model.Extension;
using Model.Grids.Factory;
using Model.Robots;
using NUnit.Framework;

namespace UnitTests
{

    public class DemoTests
    {
        IGridCreator gridCreator = new GridCreator();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FirstTest()
        {
            var grid = gridCreator.Create(5, 3);
            var coordinator = new Coordinator();
            var robots = new[]
            {
                new Robot(1, 1, Direction.E.GetDirectionDescription(), new[] { Command.R, Command.F, Command.R, Command.F, Command.R, Command.F, Command.R, Command.F }, grid),
                new Robot(3, 2, Direction.N.GetDirectionDescription(), new[] { Command.F, Command.R, Command.R, Command.F, Command.L, Command.L, Command.F, Command.F, Command.R, Command.R, Command.F, Command.L, Command.L }, grid),
                new Robot(0, 3, Direction.W.GetDirectionDescription(), new[] { Command.L, Command.L, Command.F, Command.F, Command.F, Command.L, Command.F, Command.L, Command.F, Command.L }, grid)
            };
            coordinator.LaunchRobots(robots);

            var firstRobot = robots[0];
            Assert.That(firstRobot.PositionX, Is.EqualTo(1));
            Assert.That(firstRobot.PositionY, Is.EqualTo(1));
            Assert.That(firstRobot.Direction, Is.EqualTo(Direction.E.GetDirectionDescription()));
            Assert.IsFalse(firstRobot.Fell);

            var secondRobot = robots[1];
            Assert.That(secondRobot.PositionX, Is.EqualTo(3));
            Assert.That(secondRobot.PositionY, Is.EqualTo(3));
            Assert.That(secondRobot.Direction, Is.EqualTo(Direction.N.GetDirectionDescription()));
            Assert.IsTrue(secondRobot.Fell);

            var thirdRobot = robots[2];
            Assert.That(thirdRobot.PositionX, Is.EqualTo(2));
            Assert.That(thirdRobot.PositionY, Is.EqualTo(3));
            Assert.That(thirdRobot.Direction, Is.EqualTo(Direction.S.GetDirectionDescription()));
            Assert.IsFalse(thirdRobot.Fell);
        }
    }
}
