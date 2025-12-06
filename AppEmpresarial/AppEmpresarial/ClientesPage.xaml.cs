namespace AppEmpresarial;

public partial class ClientesPage : ContentPage
{
    public ClientesPage()
    {
        InitializeComponent();
        CargarClientes();
    }

    private void CargarClientes()
    {
        ClientesList.ItemsSource = App.Database.GetClientes();
    }

    private void AgregarCliente(object sender, EventArgs e)
    {
        string nombre = NombreEntry.Text?.Trim() ?? "";
        string correo = EmailEntry.Text?.Trim() ?? "";

        if (string.IsNullOrEmpty(nombre))
        {
            DisplayAlert("Error", "Ingrese un nombre", "OK");
            return;
        }

        if (string.IsNullOrEmpty(correo))
        {
            DisplayAlert("Error", "Ingrese un correo", "OK");
            return;
        }

        var nuevo = new Cliente
        {
            Nombre = nombre,
            Email = correo
        };

        App.Database.AddCliente(nuevo);

        NombreEntry.Text = "";
        EmailEntry.Text = "";

        CargarClientes();
    }

    private void EliminarCliente(object sender, EventArgs e)
    {
        var swipeItem = sender as SwipeItem;
        var cliente = swipeItem?.BindingContext as Cliente;

        if (cliente != null)
        {
            App.Database.DeleteCliente(cliente);
            CargarClientes();
        }
    }
}
