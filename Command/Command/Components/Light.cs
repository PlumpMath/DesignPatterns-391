using System;

namespace Command.Components
{
    public class Light
    {
        private bool _on;
        public void TurnLightOn()
        {
            if (_on)
            {
                Console.WriteLine("Light already on");
            }
            else
            {
                _on = true;
                Console.WriteLine("Turning light on");
            }
            
        }

        public void TurnLightOff()
        {
            if (_on)
            {
                Console.WriteLine("Turning light off");
                _on = false;
            }
            else
            {
                Console.WriteLine("Light already off");
            }
        }
    }
}