namespace MarsRobotTests
{
    using System;
    using FluentAssertions;
    using MarsRobot;
    using MarsRobot.Directions;
    using NUnit.Framework;

    [TestFixture]
    public class MarsRobotTests
    {
        [TestCase("N", "E:0:0")]
        [TestCase("E", "S:0:0")]
        [TestCase("S", "W:0:0")]
        [TestCase("W", "N:0:0")]
        public void Given_Robot_WhenInstructionIsTurnRight_Then_RobotShouldTurnRight(string initialDirection, string expectedOutput)
        {
            // Arrange
            Robot robot = new Robot(this.CreateDirection(initialDirection), Position.Origin);

            // Act
            string output = robot.ProcessInstructions("R");

            // Assert
            output.Should().Be(expectedOutput);
        }

        [TestCase("N", "W:0:0")]
        [TestCase("E", "N:0:0")]
        [TestCase("S", "E:0:0")]
        [TestCase("W", "S:0:0")]
        public void Given_Robot_WhenInstructionIsTurnLeft_Then_RobotShouldTurnLeft(string initialDirection, string expectedOutput)
        {
            // Arrange
            Robot robot = new Robot(this.CreateDirection(initialDirection), Position.Origin);

            // Act
            string output = robot.ProcessInstructions("L");

            // Assert
            output.Should().Be(expectedOutput);
        }

        [TestCase("N", "N:0:1")]
        [TestCase("E", "E:1:0")]
        [TestCase("S", "S:0:-1")]
        [TestCase("W", "W:-1:0")]
        public void Given_Robot_When_MoveInstructionIsForward_ThenRobotMoveOneUnitForward(string initialDirection, string expectedOutput)
        {
            // Arrange
            Robot robot = new Robot(this.CreateDirection(initialDirection), Position.Origin);

            // Act
            string output = robot.ProcessInstructions("F");

            // Assert
            output.Should().Be(expectedOutput);
        }

        [TestCase("N", "N:0:-1")]
        [TestCase("E", "E:-1:0")]
        [TestCase("S", "S:0:1")]
        [TestCase("W", "W:1:0")]
        public void Given_Robot_When_MoveInstructionIsMoveBackward_ThenRobotMoveOneUnitBackward(string initialDirection, string expectedOutput)
        {
            // Arrange
            Robot robot = new Robot(this.CreateDirection(initialDirection), Position.Origin);

            // Act
            string output = robot.ProcessInstructions("B");

            // Assert
            output.Should().Be(expectedOutput);
        }

        [TestCase("FRFFLFRB", "E:1:2")]
        public void Given_Robot_When_SetOfInstructions_Then_ShouldProcessThemAll(string instructions, string expectedOutput)
        {
            // Arrange
            Robot robot = new Robot(new NorthDirection(), Position.Origin);

            // Act
            string output = robot.ProcessInstructions(instructions);

            // Assert
            output.Should().Be(expectedOutput);
        }

        private IDirection CreateDirection(string direction)
        {
            switch (direction)
            {
                case "N": return new NorthDirection();
                case "E": return new EastDirection();
                case "S": return new SouthDirection();
                case "W": return new WestDirection();
            }

            throw new InvalidOperationException();
        }
    }
}
