namespace MarsRobot
{
    public interface IDirection
    {
        IDirection TurnLeft();

        IDirection TurnRight();

        Position MoveForward(Position currentPosition);

        Position MoveBackward(Position currentPosition);

        string FormatOutput();
    }
}
