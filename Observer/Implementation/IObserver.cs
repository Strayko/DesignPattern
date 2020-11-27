namespace Observer.Implementation
{
    public interface IObserver
    {
        // Receive update from subject.
        void Update(ISubject subject);
    }
}