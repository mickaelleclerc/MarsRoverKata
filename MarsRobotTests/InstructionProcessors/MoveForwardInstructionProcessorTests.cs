namespace MarsRobotTests.InstructionProcessors
{
    using System;
    using FluentAssertions;
    using MarsRobot;
    using MarsRobot.Directions;
    using MarsRobot.InstructionProcessors;
    using NUnit.Framework;

    [TestFixture]
    public class MoveForwardInstructionProcessorTests
    {
        [Test]
        public void Given_MoveForwardInstructionProcessor_When_InstructionIsF_Then_CanProcess()
        {
            // Arrange
            MoveForwardInstructionProcessor instructionProcessor = new MoveForwardInstructionProcessor();
            
            // Act
            bool canProcess = instructionProcessor.CanProcess('F');

            // Assert
            canProcess.Should().BeTrue();
        }
        
        [Test]
        public void Given_MoveForwardInstructionProcessor_When_InstructionIsNotF_Then_CannotProcess()
        {
            // Arrange
            MoveForwardInstructionProcessor instructionProcessor = new MoveForwardInstructionProcessor();
            
            // Act
            bool canProcess = instructionProcessor.CanProcess('Z');

            // Assert
            canProcess.Should().BeFalse();
        }
        
        [Test]
        public void Given_MoveForwardInstructionProcessor_When_InstructionIsNotB_Then_ProcessThrowArgumentException()
        {
            // Arrange
            MoveForwardInstructionProcessor instructionProcessor = new MoveForwardInstructionProcessor();
            Robot robot = new Robot(new NorthDirection(), Position.Origin);
            
            // Act
            Action action = () => instructionProcessor.Process(robot, 'Z');

            // Assert
            action.Should().Throw<ArgumentException>();
        }
        
        [Test]
        public void Given_MoveForwardInstructionProcessor_When_InstructionIsB_Then_ProcessSucceed()
        {
            // Arrange
            MoveForwardInstructionProcessor instructionProcessor = new MoveForwardInstructionProcessor();
            Robot robot = new Robot(new NorthDirection(), Position.Origin);
            
            // Act
            Action action = () => instructionProcessor.Process(robot, 'F');

            // Assert
            action.Should().NotThrow<ArgumentException>();
        }
    }
}