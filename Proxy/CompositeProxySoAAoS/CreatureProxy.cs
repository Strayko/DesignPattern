namespace Proxy.CompositeProxySoAAoS
{
    public struct CreatureProxy
    {
        private readonly Creatures _creatures;
        private readonly int _index;

        public CreatureProxy(Creatures creatures, int index)
        {
            _creatures = creatures;
            _index = index;
        }

        public ref byte Age => ref _creatures.age[_index];
        public ref int X => ref _creatures.x[_index];
        public ref int Y => ref _creatures.y[_index];
    }
}