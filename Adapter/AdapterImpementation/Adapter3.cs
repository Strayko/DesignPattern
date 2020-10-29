namespace Adapter.AdapterImpementation
{
    public class Adapter3 : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter3(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{_adaptee.GetSpecificRequest()}'";
        }
    }
}