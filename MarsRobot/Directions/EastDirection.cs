namespace MarsRobot.Directions
{
    public class EastDirection : AbstractDirection
    {
        public EastDirection()
            : base("E")
        {
        }

        public override IDirection TurnLeft()
        {
            return new NorthDirection();
        }

        public override IDirection TurnRight()
        {
            return new SouthDirection();
        }

        public override Position MoveForward(Position currentPosition)
        {
            return new Position(currentPosition.X + 1, currentPosition.Y);
        }

        public override Position MoveBackward(Position currentPosition)
        {
            return new Position(currentPosition.X - 1, currentPosition.Y);
        }
    }
}