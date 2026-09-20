namespace cafeservello_UI.Services.Common.Theme
{
    public sealed class ThemeService
    {
        public string ThemeColor { get; private set; } = "theme-classic";

        public event Action? OnChange;

        public void ToggleTheme()
        {
            ThemeColor = ThemeColor == "theme-classic"
                ? "theme-light"
                : "theme-classic";

            OnChange?.Invoke();
        }
    }
}