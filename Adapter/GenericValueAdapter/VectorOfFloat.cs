namespace Adapter.GenericValueAdapter
{
    public class VectorOfFloat<TSelf, D> : VectorGene<TSelf, float, D> where D : IInteger, new() where TSelf : VectorGene<TSelf, float, D>, new()
    {
        
    }
}