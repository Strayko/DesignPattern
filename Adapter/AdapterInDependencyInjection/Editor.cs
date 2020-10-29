using System.Collections.Generic;

namespace Adapter.AdapterInDependencyInjection
{
    public class Editor
    {
        private IEnumerable<Button> buttons;

        public IEnumerable<Button> Buttons => buttons;

        public Editor(IEnumerable<Button> buttons)
        {
            this.buttons = buttons;
        }

        public void ClickAll()
        {
            foreach(var btn in buttons)
                btn.Click();
        }
    }
}