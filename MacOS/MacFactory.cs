using AbstractPatternWebApi.Interfaces;

namespace AbstractPatternWebApi.MacOS
{
    public class MacFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}
