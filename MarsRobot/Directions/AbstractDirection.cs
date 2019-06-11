namespace MarsRobot.Directions
{
    public abstract class AbstractDirection : IDirection
    {
        private readonly string symbol;

        protected AbstractDirection(string symbol)
        {
            this.symbol = symbol;
        }

        public abstract IDirection TurnLeft();

        public abstract IDirection TurnRight();

        public abstract Position MoveForward(Position currentPosition);

        public abstract Position MoveBackward(Position currentPosition);

        public string FormatOutput() => this.symbol;
    }
}
