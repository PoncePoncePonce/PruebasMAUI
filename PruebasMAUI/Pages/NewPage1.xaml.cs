namespace PruebasMAUI.Pages;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void siguiente_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new NewPage2());
    }
}