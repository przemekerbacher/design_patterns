using Bridge.Interfaces;
using System;

namespace Bridge.Components
{
    class TV : IDevice
    {
        public void Off()
        {
            Console.WriteLine("TV is Off");
        }

        public void On()
        {
            Console.WriteLine("TV is On");
        }
    }
}
