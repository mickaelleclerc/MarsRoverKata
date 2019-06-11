namespace MarsRobot.Directions
{
    public class SouthDirection : AbstractDirection
    {
        public SouthDirection()
            : base("S")
        {
        }

        public override IDirection TurnLeft()
        {
            return new EastDirection();
        }

        public override IDirection TurnRight()
        {
            return new WestDirection();
        }

        public override Position MoveForward(Position currentPosition)
        {
            return new Position(currentPosition.X, currentPosition.Y - 1);
        }

        public override Position MoveBackward(Position currentPosition)
        {
            return new Position(currentPosition.X, currentPosition.Y + 1);
        }
    }
}