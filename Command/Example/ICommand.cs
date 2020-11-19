namespace Command.Example
{
    public interface ICommand
    {
        void Call();
        void Undo();
        bool Success { get; set; }
    }
}