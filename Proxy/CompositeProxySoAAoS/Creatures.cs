using System.Collections.Generic;

namespace Proxy.CompositeProxySoAAoS
{
    public class Creatures
    {
        public readonly int size;
        public byte[] age;
        public int[] x, y;

        public Creatures(int size)
        {
            this.size = size;
            age = new byte[size];
            x = new int[size];
            y = new int[size];
        }

        public IEnumerator<CreatureProxy> GetEnumerator()
        {
            for (int pos = 0; pos < size; pos++)
            {
                yield return new CreatureProxy(this, pos);
            }
        }
    }
}