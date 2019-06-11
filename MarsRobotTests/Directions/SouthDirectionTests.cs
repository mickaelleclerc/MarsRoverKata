namespace MarsRobotTests.Directions
{
    using FluentAssertions;
    using MarsRobot;
    using MarsRobot.Directions;
    using NUnit.Framework;

    [TestFixture]
    public class SouthDirectionTests
    {
        [Test]
        public void Given_SouthDirection_When_TurnLeft_Then_DirectionShouldBeEast()
        {
            // Arrange
            SouthDirection southDirection = new SouthDirection();
            
            // Act
            IDirection newDirection = southDirection.TurnLeft();

            // Assert
            newDirection.Should().BeOfType<EastDirection>();
        }
        
        [Test]
        public void Given_SouthDirection_When_TurnRight_Then_DirectionShouldBeWest()
        {
            // Arrange
            SouthDirection southDirection = new SouthDirection();
            
            // Act
            IDirection newDirection = southDirection.TurnRight();

            // Assert
            newDirection.Should().BeOfType<WestDirection>();
        }
        
        [Test]
        public void Given_SouthDirection_When_MoveForward_Then_ShouldMoveOneUnitDown()
        {
            // Arrange
            SouthDirection southDirection = new SouthDirection();
            
            // Act
            Position position = Position.Origin;
            Position newPosition = southDirection.MoveForward(position);

            // Assert
            newPosition.Should().BeEquivalentTo(new Position(0, -1));
        }
        
        [Test]
        public void Given_SouthDirection_When_MoveBackward_Then_ShouldMoveOneUnitUp()
        {
            // Arrange
            SouthDirection southDirection = new SouthDirection();
            
            // Act
            Position position = Position.Origin;
            Position newPosition = southDirection.MoveBackward(position);

            // Assert
            newPosition.Should().BeEquivalentTo(new Position(0, 1));
        }
    }
}