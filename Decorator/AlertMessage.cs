using System;

namespace Decorator
{
    public class AlertMessage : Message
    {
        public AlertMessage(string text) : base(text)
        {
        }

        public override void PrintMessage()
        {
            Console.Beep();
            Console.WriteLine(_text);
        }
    }
}