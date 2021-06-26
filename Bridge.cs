using System;

namespace DesignPatterns
{
    public interface IDevice
    {
        bool IsEnabled();
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int volume);
        int GetChannel();
        void SetChannel(int channel);
    }

    public class Tv: IDevice
    {
        private int channel = 1;
        private int volume = 20;
        private bool isEnabled = false;

        public bool IsEnabled()
        {
            return isEnabled;
        }

        public void Enable()
        {
            isEnabled = true;
        }

        public void Disable()
        {
            isEnabled = false;
        }

        public int GetVolume()
        {
            return volume;
        }

        public void SetVolume(int volume)
        {
            this.volume = volume;
        }

        public int GetChannel()
        {
            return channel;
        }

        public void SetChannel(int channel)
        {
            this.channel = channel;
        }
    }

    public class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public RemoteControl TogglePower()
        {
            if (device.IsEnabled())
                device.Disable();
            else
                device.Enable();

            return this;
        }

        public RemoteControl VolumeDown()
        {
            device.SetVolume(device.GetVolume() - 10);

            return this;
        }

        public RemoteControl VolumeUp()
        {
            device.SetVolume(device.GetVolume() + 10);

            return this;
        }

        public RemoteControl ChannelDown()
        {
            device.SetChannel(device.GetChannel() - 1);

            return this;
        }

        public RemoteControl ChannelUp()
        {
            device.SetChannel(device.GetChannel() + 1);

            return this;
        }
    }
}
