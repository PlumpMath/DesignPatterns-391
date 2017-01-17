using Command.Components;

namespace Command.Commands
{
    public class ACOffCommand : ICommand
    {
        private readonly AC _ac;
        public ACOffCommand(AC ac)
        {
            _ac = ac;
        }

        public void Execute()
        {
            _ac.TurnACOff();
        }

        public void Undo()
        {
            _ac.Revert();
        }
    }
}