using AbstractPatternWebApi.Interfaces;

namespace AbstractPatternWebApi.Windows
{
    public class WindowsFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
