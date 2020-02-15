using Bridge.Interfaces;
using System;

namespace Bridge.Components
{
    public class Radio : IDevice
    {
        public void Off()
        {
            Console.WriteLine("Radio is Off");
        }

        public void On()
        {
            Console.WriteLine("Radio is On");
        }
    }
}
