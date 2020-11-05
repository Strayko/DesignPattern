using System.Text;

namespace Flyweight.TextFormatting
{
    public class FormattedText
    {
        private readonly string _plainText;
        private bool[] capitalize;

        public FormattedText(string plainText)
        {
            _plainText = plainText;
            capitalize = new bool[plainText.Length];
        }

        public void Capitalize(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                capitalize[i] = true;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < _plainText.Length; i++)
            {
                var c = _plainText[i];
                sb.Append(capitalize[i] ? char.ToUpper(c) : c);
            }

            return sb.ToString();
        }
    }
}