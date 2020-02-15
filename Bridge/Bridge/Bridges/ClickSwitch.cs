namespace Bridge.Interfaces
{
    class ClickSwitch : Switch
    {
        public ClickSwitch(IDevice device) : base(device){ }
        public override void Off()
        {
            device.Off();
        }

        public override void On()
        {
            device.On();
        }
    }
}
