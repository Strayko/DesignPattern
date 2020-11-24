using System;
using System.Reactive.Linq;
using System.Threading.Channels;
using Console = System.Console;

namespace Mediator.EventBroker
{
    public class FootballPlayer : Actor
    {
        public string Name { get; set; }
        public int GoalsScored { get; set; } = 0;

        public void Score()
        {
            GoalsScored++;
            broker.Publish(new PlayerScoredEvent {Name = Name, GoalsScored = GoalsScored});
        }

        public void AssaultReferee()
        {
            broker.Publish(new PlayerSentOffEvent {Name = Name, Reason = "violence"});
        }

        public FootballPlayer(EventBroker broker, string name) : base(broker)
        {
            Name = name;

            broker.OfType<PlayerScoredEvent>()
                .Where(ps => !ps.Name.Equals(name))
                .Subscribe(
                    ps => Console.WriteLine($"{name}: Nicely done, {ps.Name}! It's your {ps.GoalsScored}")
                );

            broker.OfType<PlayerSentOffEvent>()
                .Where(ps => !ps.Name.Equals(name))
                .Subscribe(ps => Console.WriteLine($"{name}: see you in the lockers, {ps.Name}"));
        }
    }
}