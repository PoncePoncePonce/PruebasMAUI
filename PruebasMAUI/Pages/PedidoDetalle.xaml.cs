namespace PruebasMAUI.Pages;

public partial class PedidoDetalle : ContentPage
{
	public PedidoDetalle()
	{
		InitializeComponent();
	}

    private async void Finalizar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}