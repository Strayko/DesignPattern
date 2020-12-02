namespace Visitor.AcyclicVisitor
{
    public interface IVisitor<TVisitable>
    {
        void Visit(TVisitable obj);
    }
    
    public interface IVisitor { }
}