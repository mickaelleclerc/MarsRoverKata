namespace MarsRobot
{
    public interface IInstructionProcessor
    {
        bool CanProcess(char instruction);

        void Process(Robot robot, char instruction);
    }
}
