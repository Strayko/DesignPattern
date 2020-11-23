namespace Iterator.Implementation
{
    public class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;
        
        // Stores the current traversal position. An iterator may have a lot of
        // other fields for storing iteration state, especially when it is
        // supposed to work with a particular kind of collection.
        private int _position = -1;

        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;
            if (reverse)
            {
                _position = collection.getItems().Count;
            }
        }
        
        public override int Key()
        {
            return _position;
        }

        public override object Current()
        {
            return _collection.getItems()[_position];
        }

        public override bool MoveNext()
        {
            int updatePosition = _position + (_reverse ? -1 : 1);
            if (updatePosition >= 0 && updatePosition < _collection.getItems().Count)
            {
                _position = updatePosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _position = _reverse ? _collection.getItems().Count - 1 : 0;
        }
    }
}