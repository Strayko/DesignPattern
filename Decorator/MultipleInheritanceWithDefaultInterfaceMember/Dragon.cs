namespace Decorator.MultipleInheritanceWithDefaultInterfaceMember
{
    public class Dragon : Organism, IBird, ILizard
    {
        public int Age { get; set; }
    }
}