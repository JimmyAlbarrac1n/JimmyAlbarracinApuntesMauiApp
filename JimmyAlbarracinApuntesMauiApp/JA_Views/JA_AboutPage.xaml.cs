namespace JimmyAlbarracinApuntesMauiApp.JA_Views;

public partial class JA_AboutPage : ContentPage
{
	public JA_AboutPage()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        // Navigate to the specified URL in the system browser.
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}