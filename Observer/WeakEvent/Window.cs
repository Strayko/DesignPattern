#nullable enable
using System;
using System.Windows;

namespace Observer.WeakEvent
{
    public class Window
    {
        public Window(Button button)
        {
            // WeakEventManager<Button, EventArgs>
            //     .AddHandler(button, "Clicked", ButtonOnClicked);
        }

        private void ButtonOnClicked(object? sender, EventArgs e)
        {
            if (sender == null) throw new ArgumentNullException(nameof(sender));
            Console.WriteLine("Button clicked (Window handler)");
        }

        ~Window()
        {
            Console.WriteLine("Window finalized");
        }
    }
}