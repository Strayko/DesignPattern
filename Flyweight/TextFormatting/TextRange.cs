namespace Flyweight.TextFormatting
{
    public class TextRange
    {
        public int Start, End;
        public bool Capitalize, Bold, Italic;

        public bool Covers(int position)
        {
            return position >= Start && position <= End;
        }
    }
}