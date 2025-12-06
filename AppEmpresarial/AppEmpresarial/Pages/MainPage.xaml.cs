namespace AppEmpresarial;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        SaludoLabel.Text = $"Hola, {App.UsuarioActual}";
    }

    private async void OpenProductos(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductosPage());
    }

    private async void OpenClientes(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientesPage());
    }

    private async void OpenVentas(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new VentasPage());
    }

    private async void OpenStock(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StockPage());
    }
}
