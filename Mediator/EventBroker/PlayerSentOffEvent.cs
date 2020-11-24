namespace Mediator.EventBroker
{
    public class PlayerSentOffEvent : PlayerEvent
    {
        public string Reason { get; set; }
    }
}