namespace Mediator.EventBroker
{
    public class Actor
    {
        protected EventBroker broker;

        public Actor(EventBroker broker)
        {
            this.broker = broker;
        }
    }
}