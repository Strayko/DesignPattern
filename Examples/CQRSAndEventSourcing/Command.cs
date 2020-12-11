using System;

namespace Examples.CQRSAndEventSourcing
{
    public class Command : EventArgs
    {
        public bool Register = true;
    }
}