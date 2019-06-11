namespace MarsRobotTests.Directions
{
    using FluentAssertions;
    using MarsRobot;
    using MarsRobot.Directions;
    using NUnit.Framework;

    [TestFixture]
    public class NorthDirectionTests
    {
        [Test]
        public void Given_NorthDirection_When_TurnLeft_Then_DirectionShouldBeWest()
        {
            // Arrange
            NorthDirection northDirection = new NorthDirection();
            
            // Act
            IDirection newDirection = northDirection.TurnLeft();

            // Assert
            newDirection.Should().BeOfType<WestDirection>();
        }
        
        [Test]
        public void Given_NorthDirection_When_TurnRight_Then_DirectionShouldBeEast()
        {
            // Arrange
            NorthDirection northDirection = new NorthDirection();
            
            // Act
            IDirection newDirection = northDirection.TurnRight();

            // Assert
            newDirection.Should().BeOfType<EastDirection>();
        }
        
        [Test]
        public void Given_NorthDirection_When_MoveForward_Then_ShouldMoveOneUnitUp()
        {
            // Arrange
            NorthDirection northDirection = new NorthDirection();
            
            // Act
            Position position = Position.Origin;
            Position newPosition = northDirection.MoveForward(position);

            // Assert
            newPosition.Should().BeEquivalentTo(new Position(0, 1));
        }
        
        [Test]
        public void Given_NorthDirection_When_MoveBackward_Then_ShouldMoveOneUnitDown()
        {
            // Arrange
            NorthDirection northDirection = new NorthDirection();
            
            // Act
            Position position = Position.Origin;
            Position newPosition = northDirection.MoveBackward(position);

            // Assert
            newPosition.Should().BeEquivalentTo(new Position(0, -1));
        }
    }
}