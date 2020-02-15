﻿namespace Bridge.Interfaces
{
    public abstract class Switch
    {
        protected IDevice device;
        public Switch(IDevice device)
        {
            this.device = device;
        }

        public abstract void On();
        public abstract void Off();
    }
}
