#nullable enable
using System;

namespace Observer.ViaEventKey
{
    public class Person
    {
        public void CatchACold()
        {
            FallsIll?.Invoke(this, new FallsIllEventArgs {Address = "123 London Road"});
        }
        
        public event EventHandler<FallsIllEventArgs> FallsIll = null!;
        
        private static void CallDoctor(object? sender, FallsIllEventArgs eventArgs)
        {
            if (sender == null) throw new ArgumentNullException(nameof(sender));
            Console.WriteLine($"A doctor has been called to {eventArgs.Address}");
        }
    }
}