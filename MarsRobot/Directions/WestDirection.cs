namespace MarsRobot.Directions
{
    public class WestDirection : AbstractDirection
    {
        public WestDirection()
            : base("W")
        {
        }

        public override IDirection TurnLeft()
        {
            return new SouthDirection();
        }

        public override IDirection TurnRight()
        {
            return new NorthDirection();
        }

        public override Position MoveForward(Position currentPosition)
        {
            return new Position(currentPosition.X - 1, currentPosition.Y);
        }

        public override Position MoveBackward(Position currentPosition)
        {
            return new Position(currentPosition.X + 1, currentPosition.Y);
        }
    }
}