namespace SplashScreen;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        // Here you can add authentication logic
        // For now, we will navigate to the home page directly
        Application.Current.MainPage = new NavigationPage(new HomePage());
    }
}