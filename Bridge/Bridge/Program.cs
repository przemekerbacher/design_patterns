using Bridge.Components;
using Bridge.Interfaces;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new TV();
            var tvButton = new ClickSwitch(tv);
            tvButton.On();
            tvButton.Off();

            var radio = new Radio();
            var radioButton = new ClickSwitch(radio);
            radioButton.On();
            radioButton.Off();

            Console.ReadKey();
        }
    }
}
