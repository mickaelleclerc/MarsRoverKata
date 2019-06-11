namespace MarsRobotTests.InstructionProcessors
{
    using System;
    using FluentAssertions;
    using MarsRobot;
    using MarsRobot.Directions;
    using MarsRobot.InstructionProcessors;
    using NUnit.Framework;

    [TestFixture]
    public class MoveBackwardInstructionProcessorTests
    {
        [Test]
        public void Given_MoveBackwardInstructionProcessor_When_InstructionIsB_Then_CanProcess()
        {
            // Arrange
            MoveBackwardInstructionProcessor instructionProcessor = new MoveBackwardInstructionProcessor();
            
            // Act
            bool canProcess = instructionProcessor.CanProcess('B');

            // Assert
            canProcess.Should().BeTrue();
        }
        
        [Test]
        public void Given_MoveBackwardInstructionProcessor_When_InstructionIsNotB_Then_CannotProcess()
        {
            // Arrange
            MoveBackwardInstructionProcessor instructionProcessor = new MoveBackwardInstructionProcessor();
            
            // Act
            bool canProcess = instructionProcessor.CanProcess('Z');

            // Assert
            canProcess.Should().BeFalse();
        }
        
        [Test]
        public void Given_MoveBackwardInstructionProcessor_When_InstructionIsNotB_Then_ProcessThrowArgumentException()
        {
            // Arrange
            MoveBackwardInstructionProcessor instructionProcessor = new MoveBackwardInstructionProcessor();
            Robot robot = new Robot(new NorthDirection(), Position.Origin);
            
            // Act
            Action action = () => instructionProcessor.Process(robot, 'Z');

            // Assert
            action.Should().Throw<ArgumentException>();
        }
        
        [Test]
        public void Given_MoveBackwardInstructionProcessor_When_InstructionIsB_Then_ProcessSucceed()
        {
            // Arrange
            MoveBackwardInstructionProcessor instructionProcessor = new MoveBackwardInstructionProcessor();
            Robot robot = new Robot(new NorthDirection(), Position.Origin);
            
            // Act
            Action action = () => instructionProcessor.Process(robot, 'B');

            // Assert
            action.Should().NotThrow<ArgumentException>();
        }
    }
}