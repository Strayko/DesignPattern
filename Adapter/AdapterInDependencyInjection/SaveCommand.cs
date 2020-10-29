using System;

namespace Adapter.AdapterInDependencyInjection
{
    public class SaveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Saving a file");
        }
    }
}