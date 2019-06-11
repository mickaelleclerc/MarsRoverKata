namespace MarsRobot.InstructionProcessors
{
    using System;

    public class TurnLeftInstructionProcessor : IInstructionProcessor
    {
        public bool CanProcess(char instruction) => instruction == 'L';

        public void Process(Robot robot, char instruction)
        {
            if (!this.CanProcess(instruction))
            {
                throw new ArgumentException($"{instruction} can be process by instruction processor {this.GetType().Name}");
            }
            
            robot.TurnLeft();
        }
    }
}
