using System.Collections.Generic;
using Command.Commands;

namespace Command
{
    public class RemoteControl
    {
        private readonly List<ICommand> _onCommands = new List<ICommand>();
        private readonly List<ICommand> _offCommands = new List<ICommand>();
        private ICommand _lastCommand;

        public void SetOnCommand(ICommand command, int index)
        {
            _onCommands.Insert(index, command);
        }

        public void SetOffCommand(ICommand command, int index)
        {
            _offCommands.Insert(index, command);
        }

        public void ExecuteOnCommand(int index)
        {
            _onCommands[index].Execute();
            _lastCommand = _onCommands[index];
        }

        public void ExecuteOffCommand(int index)
        {
            _offCommands[index].Execute();
            _lastCommand = _offCommands[index];
        }

        public void Undo()
        {
            _lastCommand.Undo();
        }
    }
}