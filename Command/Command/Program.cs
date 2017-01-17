using Command.Commands;
using Command.Components;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();

            Light light = new Light();
            ICommand lightOnCommand = new LightOnCommand(light);
            ICommand lightOffCommand = new LightOffCommand(light);

            AC ac = new AC();
            ICommand acOnCommand = new ACOnCommand(ac);
            ICommand acOffCommand = new ACOffCommand(ac);

            remote.SetOnCommand(lightOnCommand, 0);
            remote.SetOffCommand(lightOffCommand, 0);

            remote.SetOnCommand(acOnCommand, 1);
            remote.SetOffCommand(acOffCommand, 1);

            remote.ExecuteOnCommand(0);
            remote.ExecuteOnCommand(0);

            remote.ExecuteOnCommand(1);
            remote.ExecuteOnCommand(1);
            remote.ExecuteOnCommand(1);
            remote.ExecuteOffCommand(1);
            remote.ExecuteOffCommand(1);
            remote.ExecuteOnCommand(1);
            remote.ExecuteOnCommand(1);
            remote.ExecuteOnCommand(1);
            remote.ExecuteOnCommand(1);
            remote.ExecuteOnCommand(1);
        }
    }
}
