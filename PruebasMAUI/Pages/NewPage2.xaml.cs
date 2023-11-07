namespace PruebasMAUI.Pages;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}
    private void siguiente_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PedidosSelect());
    }
}