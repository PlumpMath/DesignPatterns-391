using Command.Components;

namespace Command.Commands
{
    public class ACOnCommand : ICommand
    {
        private readonly AC _ac;
        public ACOnCommand(AC ac)
        {
            _ac = ac;
        }

        public void Execute()
        {
            _ac.TurnACOn();
        }

        public void Undo()
        {
            _ac.Revert();
        }
    }
}