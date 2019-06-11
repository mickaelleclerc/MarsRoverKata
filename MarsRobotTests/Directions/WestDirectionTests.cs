namespace MarsRobotTests.Directions
{
    using FluentAssertions;
    using MarsRobot;
    using MarsRobot.Directions;
    using NUnit.Framework;

    [TestFixture]
    public class WestDirectionTests
    {
        [Test]
        public void Given_WestDirection_When_TurnLeft_Then_DirectionShouldBeSouth()
        {
            // Arrange
            WestDirection westDirection = new WestDirection();
            
            // Act
            IDirection newDirection = westDirection.TurnLeft();

            // Assert
            newDirection.Should().BeOfType<SouthDirection>();
        }
        
        [Test]
        public void Given_WestDirection_When_TurnRight_Then_DirectionShouldBeNorth()
        {
            // Arrange
            WestDirection westDirection = new WestDirection();
            
            // Act
            IDirection newDirection = westDirection.TurnRight();

            // Assert
            newDirection.Should().BeOfType<NorthDirection>();
        }
        
        [Test]
        public void Given_WestDirection_When_MoveForward_Then_ShouldMoveOneUnitLeft()
        {
            // Arrange
            WestDirection westDirection = new WestDirection();
            
            // Act
            Position position = Position.Origin;
            Position newPosition = westDirection.MoveForward(position);

            // Assert
            newPosition.Should().BeEquivalentTo(new Position(-1, 0));
        }
        
        [Test]
        public void Given_WestDirection_When_MoveBackward_Then_ShouldMoveOneUnitRight()
        {
            // Arrange
            WestDirection westDirection = new WestDirection();
            
            // Act
            Position position = Position.Origin;
            Position newPosition = westDirection.MoveBackward(position);

            // Assert
            newPosition.Should().BeEquivalentTo(new Position(1, 0));
        }
    }
}