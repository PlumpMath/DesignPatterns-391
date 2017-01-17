using Command.Components;

namespace Command.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;
        public LightOnCommand(Light lightComponent)
        {
            _light = lightComponent;
        }

        public void Execute()
        {
            _light.TurnLightOn();
        }

        public void Undo()
        {
            _light.TurnLightOff();
        }
    }
}