namespace MarsRobotTests.Directions
{
    using FluentAssertions;
    using MarsRobot;
    using MarsRobot.Directions;
    using NUnit.Framework;

    [TestFixture]
    public class EastDirectionTests
    {
        [Test]
        public void Given_EastDirection_When_TurnLeft_Then_DirectionShouldBeNorth()
        {
            // Arrange
            EastDirection eastDirection = new EastDirection();
            
            // Act
            IDirection newDirection = eastDirection.TurnLeft();

            // Assert
            newDirection.Should().BeOfType<NorthDirection>();
        }
        
        [Test]
        public void Given_EastDirection_When_TurnRight_Then_DirectionShouldBeSouth()
        {
            // Arrange
            EastDirection eastDirection = new EastDirection();
            
            // Act
            IDirection newDirection = eastDirection.TurnRight();

            // Assert
            newDirection.Should().BeOfType<SouthDirection>();
        }

        [Test]
        public void Given_EastDirection_When_MoveForward_Then_ShouldMoveOneUnitRight()
        {
            // Arrange
            EastDirection eastDirection = new EastDirection();
            
            // Act
            Position position = Position.Origin;
            Position newPosition = eastDirection.MoveForward(position);

            // Assert
            newPosition.Should().BeEquivalentTo(new Position(1, 0));
        }
        
        [Test]
        public void Given_EastDirection_When_MoveBackward_Then_ShouldMoveOneUnitLeft()
        {
            // Arrange
            EastDirection eastDirection = new EastDirection();
            
            // Act
            Position position = Position.Origin;
            Position newPosition = eastDirection.MoveBackward(position);

            // Assert
            newPosition.Should().BeEquivalentTo(new Position(-1, 0));
        }
    }
}