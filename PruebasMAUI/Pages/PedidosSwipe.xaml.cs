using PruebasMAUI.Models.ViewModels;
using PruebasMAUI.Models;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace PruebasMAUI.Pages;

public partial class PedidosSwipe : ContentPage
{
	public PedidosSwipe()
	{
		InitializeComponent();
        IniciarLista();
    }
    ObservableCollection<Employee> objetos;
    private async void IniciarLista()
    {
        HttpClient client = new HttpClient();
        var info = await client.GetStringAsync("https://deb39002-6d81-485f-9ba9-2f73fc2a7127.mock.pstmn.io/MockMaui2");
        var lista = JsonConvert.DeserializeObject<ObservableCollection<Employee>>(info);
        collectionView.ItemsSource = lista;
    }

    private void Adicion_Clicked(object sender, EventArgs e)
    {
        Employee employee = new Employee(Id.Text, Name.Text, Email.Text, Blocked.IsToggled);
        objetos.Add(employee);
        Id.Text = null; Name.Text = null; Email.Text = null; Blocked.IsToggled = false;
    }

    private void Borrar_Clicked(object sender, EventArgs e)
    {
        SwipeItem item = sender as Microsoft.Maui.Controls.SwipeItem;
        if (item is null)
            return;

        Employee employee = item.BindingContext as Employee;
        objetos.Remove(employee);
    }

    private async void Detalles_Clicked(object sender, EventArgs e)
    {
        SwipeItem item = sender as SwipeItem;
        if (item is null)
            return;

        Employee employee = item.BindingContext as Employee;
        EmployeeDetailViewModel employeeDetailViewModel = new EmployeeDetailViewModel { Employee = employee };
        PedidoDetalle pedidoDetalle = new PedidoDetalle();
        pedidoDetalle.BindingContext = employeeDetailViewModel;
        await Navigation.PushAsync(pedidoDetalle);
    }
}