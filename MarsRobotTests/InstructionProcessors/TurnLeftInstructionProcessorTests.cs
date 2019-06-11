namespace MarsRobotTests.InstructionProcessors
{
    using System;
    using FluentAssertions;
    using MarsRobot;
    using MarsRobot.Directions;
    using MarsRobot.InstructionProcessors;
    using NUnit.Framework;

    [TestFixture]
    public class TurnLeftInstructionProcessorTests
    {
        [Test]
        public void Given_TurnLeftInstructionProcessor_When_InstructionIsL_Then_CanProcess()
        {
            // Arrange
            TurnLeftInstructionProcessor instructionProcessor = new TurnLeftInstructionProcessor();
            
            // Act
            bool canProcess = instructionProcessor.CanProcess('L');

            // Assert
            canProcess.Should().BeTrue();
        }
        
        [Test]
        public void Given_TurnLeftInstructionProcessor_When_InstructionIsNotL_Then_CannotProcess()
        {
            // Arrange
            TurnLeftInstructionProcessor instructionProcessor = new TurnLeftInstructionProcessor();
            
            // Act
            bool canProcess = instructionProcessor.CanProcess('Z');

            // Assert
            canProcess.Should().BeFalse();
        }
        
        [Test]
        public void Given_TurnLeftInstructionProcessor_When_InstructionIsNotB_Then_ProcessThrowArgumentException()
        {
            // Arrange
            TurnLeftInstructionProcessor instructionProcessor = new TurnLeftInstructionProcessor();
            Robot robot = new Robot(new NorthDirection(), Position.Origin);
            
            // Act
            Action action = () => instructionProcessor.Process(robot, 'Z');

            // Assert
            action.Should().Throw<ArgumentException>();
        }
        
        [Test]
        public void Given_TurnLeftInstructionProcessor_When_InstructionIsB_Then_ProcessSucceed()
        {
            // Arrange
            TurnLeftInstructionProcessor instructionProcessor = new TurnLeftInstructionProcessor();
            Robot robot = new Robot(new NorthDirection(), Position.Origin);
            
            // Act
            Action action = () => instructionProcessor.Process(robot, 'L');

            // Assert
            action.Should().NotThrow<ArgumentException>();
        }
    }
}