using AbstractPatternWebApi.Interfaces;

namespace AbstractPatternWebApi.Windows
{
    public class WindowsButton : IButton
    {
        public string Render()
        {
            return "Window button";
        }
    }
}
