namespace AbstractPatternWebApi.Interfaces
{
    public interface IGuiFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
