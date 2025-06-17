using AbstractPatternWebApi.Interfaces;

namespace AbstractPatternWebApi.MacOS
{
    public class MacButton : IButton
    {
        public string Render()
        {
            return "Rendering Mac style Button";
        }
    }
}
