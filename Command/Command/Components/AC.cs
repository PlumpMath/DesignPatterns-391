using System;

namespace Command.Components
{
    public enum FanSpeed
    {
        Off,
        Low,
        Medium,
        High,
        Max
    }
    public class AC
    {
        private FanSpeed _fanSpeed = FanSpeed.Off;
        private FanSpeed _oldSpeed;
        private bool _on;
        public void TurnACOn()
        {
            if (_on)
            {
                _oldSpeed = _fanSpeed;
                AdjustFanSpeed();
            }
            else
            {
                _on = true;
                _fanSpeed = FanSpeed.Low;
                Console.WriteLine("Turning AC on");
            }

        }

        public void TurnACOff()
        {
            if (_on)
            {
                Console.WriteLine("Turning AC off");
                _on = false;
                _fanSpeed = FanSpeed.Off;
            }
            else
            {
                Console.WriteLine("AC already off");
            }
        }

        public void Revert()
        {
            if (_oldSpeed == FanSpeed.Off)
            {
                TurnACOff();
            }
            else
            {
                Console.WriteLine("Setting fan speed to previous");
                _fanSpeed = _oldSpeed;
            }
        }

        private void AdjustFanSpeed()
        {
            switch (_fanSpeed)
            {
                case FanSpeed.Low:
                    _fanSpeed = FanSpeed.Medium;
                    Console.WriteLine("Setting fan speed to medium");
                    break;
                case FanSpeed.Medium:
                    _fanSpeed = FanSpeed.High;
                    Console.WriteLine("Setting fan speed to high");
                    break;
                case FanSpeed.High:
                    _fanSpeed = FanSpeed.Max;
                    Console.WriteLine("Setting fan speed to max");
                    break;
                default:
                    _fanSpeed = FanSpeed.Low;
                    Console.WriteLine("Setting fan speed to low");
                    break;
            }
        }
    }
}