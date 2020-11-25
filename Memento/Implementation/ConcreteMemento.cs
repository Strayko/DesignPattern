using System;

namespace Memento.Implementation
{
    // The Concrete Memento contains the infrastructure for storing the
    // Originator's state.
    public class ConcreteMemento : IMemento
    {
        private string _state;
        private DateTime _date;

        public ConcreteMemento(string state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        // The rest of the methods are used by the Caretaker to display
        // metadata.
        public string GetName()
        {
            return $"{_date} / ({_state.Substring(0, 9)})...";
        }

        // The Originator uses this method when restoring its state.
        public string GetState()
        {
            return _state;
        }

        public DateTime GetDate()
        {
            return _date;
        }
    }
}