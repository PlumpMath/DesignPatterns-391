using Command.Components;

namespace Command.Commands
{
    public class LightOffCommand : ICommand
    {
        private readonly Light _light;
        public LightOffCommand(Light lightComponent)
        {
            _light = lightComponent;
        }

        public void Execute()
        {
            _light.TurnLightOff();
        }

        public void Undo()
        {
            _light.TurnLightOn();
        }
    }
}