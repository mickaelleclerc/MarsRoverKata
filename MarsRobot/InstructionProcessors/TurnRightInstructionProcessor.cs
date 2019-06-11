namespace MarsRobot.InstructionProcessors
{
    using System;

    public class TurnRightInstructionProcessor : IInstructionProcessor
    {
        public bool CanProcess(char instruction) => instruction == 'R';

        public void Process(Robot robot, char instruction)
        {
            if (!this.CanProcess(instruction))
            {
                throw new ArgumentException($"{instruction} can be process by instruction processor {this.GetType().Name}");
            }
            
            robot.TurnRight();
        }
    }
}
