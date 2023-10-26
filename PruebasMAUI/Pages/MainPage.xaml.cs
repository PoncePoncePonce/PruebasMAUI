using PruebasMAUI.Pages;

namespace PruebasMAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void btn_login_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Select());
    }
}

