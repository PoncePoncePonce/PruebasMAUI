using Newtonsoft.Json;
using PruebasMAUI.Models;
using PruebasMAUI.Models.ViewModels;
using System.Collections.ObjectModel;

namespace PruebasMAUI.Pages;

public partial class PedidosSelect : ContentPage
{
    //CHECAR VISUALSTATE PARA COLOR DE LOS SELECCIONADOS (XAML)
	public PedidosSelect()
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

    private async void Detalles_Clicked(object sender, EventArgs e)
    {
        Employee employee = (Employee)collectionView.SelectedItem;
        EmployeeDetailViewModel employeeDetailViewModel = new EmployeeDetailViewModel { Employee = employee };
        PedidoDetalle pedidoDetalle = new PedidoDetalle();
        pedidoDetalle.BindingContext = employeeDetailViewModel;
        await Navigation.PushAsync(pedidoDetalle);
    }

    private void Eliminar_Clicked(object sender, EventArgs e)
    {
        Employee employee = (Employee)collectionView.SelectedItem;

        if (employee.Blocked == true)
            return;
        objetos.Remove(employee);
    }
}