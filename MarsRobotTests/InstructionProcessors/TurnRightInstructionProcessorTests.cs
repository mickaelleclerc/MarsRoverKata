namespace MarsRobotTests.InstructionProcessors
{
    using System;
    using FluentAssertions;
    using MarsRobot;
    using MarsRobot.Directions;
    using MarsRobot.InstructionProcessors;
    using NUnit.Framework;

    [TestFixture]
    public class TurnRightInstructionProcessorTests
    {
        [Test]
        public void Given_TurnRightInstructionProcessor_When_InstructionIsR_Then_CanProcess()
        {
            // Arrange
            TurnRightInstructionProcessor instructionProcessor = new TurnRightInstructionProcessor();
            
            // Act
            bool canProcess = instructionProcessor.CanProcess('R');

            // Assert
            canProcess.Should().BeTrue();
        }
        
        [Test]
        public void Given_TurnRightInstructionProcessor_When_InstructionIsNotR_Then_CannotProcess()
        {
            // Arrange
            TurnRightInstructionProcessor instructionProcessor = new TurnRightInstructionProcessor();
            
            // Act
            bool canProcess = instructionProcessor.CanProcess('Z');

            // Assert
            canProcess.Should().BeFalse();
        }
        
        [Test]
        public void Given_TurnRightInstructionProcessor_When_InstructionIsNotB_Then_ProcessThrowArgumentException()
        {
            // Arrange
            TurnRightInstructionProcessor instructionProcessor = new TurnRightInstructionProcessor();
            Robot robot = new Robot(new NorthDirection(), Position.Origin);
            
            // Act
            Action action = () => instructionProcessor.Process(robot, 'Z');

            // Assert
            action.Should().Throw<ArgumentException>();
        }
        
        [Test]
        public void Given_TurnRightInstructionProcessor_When_InstructionIsB_Then_ProcessSucceed()
        {
            // Arrange
            TurnRightInstructionProcessor instructionProcessor = new TurnRightInstructionProcessor();
            Robot robot = new Robot(new NorthDirection(), Position.Origin);
            
            // Act
            Action action = () => instructionProcessor.Process(robot, 'R');

            // Assert
            action.Should().NotThrow<ArgumentException>();
        }
    }
}