namespace Mediator.EventBroker
{
    public class PlayerScoredEvent : PlayerEvent
    {
        public int GoalsScored { get; set; }
    }
}