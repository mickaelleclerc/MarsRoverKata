namespace MarsRobot.InstructionProcessors
{
    using System;

    public class MoveBackwardInstructionProcessor : IInstructionProcessor
    {
        public bool CanProcess(char instruction) => instruction == 'B';

        public void Process(Robot robot, char instruction)
        {
            if (!this.CanProcess(instruction))
            {
                throw new ArgumentException($"{instruction} can be process by instruction processor {this.GetType().Name}");
            }
            
            robot.MoveBackward();
        }
    }
}
