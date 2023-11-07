namespace PruebasMAUI.Pages;

public partial class Select : ContentPage
{
	public Select()
	{
		InitializeComponent();
	}
    private async void RegistrarSwipe_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PedidosSwipe());
    }

    private async void RegistrarSelect_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage1());
    }
}