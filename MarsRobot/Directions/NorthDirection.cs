namespace MarsRobot.Directions
{
    public class NorthDirection : AbstractDirection
    {
        public NorthDirection()
            : base("N")
        {
        }

        public override IDirection TurnLeft()
        {
            return new WestDirection();
        }

        public override IDirection TurnRight()
        {
            return new EastDirection();
        }

        public override Position MoveForward(Position currentPosition)
        {
            return new Position(currentPosition.X, currentPosition.Y + 1);
        }

        public override Position MoveBackward(Position currentPosition)
        {
            return new Position(currentPosition.X, currentPosition.Y - 1);
        }
    }
}
