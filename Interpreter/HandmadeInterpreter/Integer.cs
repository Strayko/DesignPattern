namespace Interpreter.HandmadeInterpreter
{
    public class Integer : IElement
    {
        public int Value { get; }

        public Integer(int value)
        {
            Value = value;
        }
    }
}