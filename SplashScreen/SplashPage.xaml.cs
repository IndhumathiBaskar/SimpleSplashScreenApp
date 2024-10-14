namespace SplashScreen;

public partial class SplashPage : ContentPage
{
    public SplashPage()
    {
        InitializeComponent();
        // Call method to handle the splash screen
        LoadSplash();
    }

    private async void LoadSplash()
    {
        await Task.Delay(10000); // Show the splash screen for 3 seconds
        Application.Current.MainPage = new NavigationPage(new LoginPage());
    }
}