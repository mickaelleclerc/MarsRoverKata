namespace MarsRobot
{
    using System.Collections.Generic;
    using System.Linq;
    using MarsRobot.InstructionProcessors;

    public class Robot
    {
        private IDirection direction;
        private Position position;

        private readonly List<IInstructionProcessor> instructionProcessors;

        public Robot(IDirection direction, Position position)
        {
            this.direction = direction;
            this.position = position;
            
            this.instructionProcessors = new List<IInstructionProcessor>
            {
                new TurnLeftInstructionProcessor(),
                new TurnRightInstructionProcessor(),
                new MoveForwardInstructionProcessor(),
                new MoveBackwardInstructionProcessor()
            };
        }

        public string ProcessInstructions(string instructions)
        {
            foreach (char instruction in instructions)
            {
                this.FindProcessor(instruction)?.Process(this, instruction);
            }
            
            return $"{this.direction.FormatOutput()}:{this.position.FormatOutput()}";
        }

        public void TurnLeft()
        {
            this.direction = this.direction.TurnLeft();
        }

        public void TurnRight()
        {
            this.direction = this.direction.TurnRight();
        }

        public void MoveForward()
        {
            this.position = this.direction.MoveForward(this.position);
        }

        public void MoveBackward()
        {
            this.position = this.direction.MoveBackward(this.position);
        }

        private IInstructionProcessor FindProcessor(char instruction)
        {
            return this.instructionProcessors.FirstOrDefault(processor => processor.CanProcess(instruction));
        }
    }
}