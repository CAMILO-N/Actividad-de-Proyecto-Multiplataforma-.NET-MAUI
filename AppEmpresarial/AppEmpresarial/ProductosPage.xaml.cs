namespace AppEmpresarial;

public partial class ProductosPage : ContentPage
{
    public ProductosPage()
    {
        InitializeComponent();
        CargarProductos();
    }

    private void CargarProductos()
    {
        ProductosList.ItemsSource = App.Database.GetProductos();
    }

    private void AgregarProducto(object sender, EventArgs e)
    {
        string nombre = NombreEntry.Text?.Trim() ?? "";
        double precio = 0;

        if (string.IsNullOrEmpty(nombre))
        {
            DisplayAlert("Error", "Ingrese un nombre", "OK");
            return;
        }

        if (!double.TryParse(PrecioEntry.Text, out precio))
        {
            DisplayAlert("Error", "Precio inválido", "OK");
            return;
        }

        var nuevo = new Producto
        {
            Nombre = nombre,
            Precio = precio
        };

        App.Database.AddProducto(nuevo);

        NombreEntry.Text = "";
        PrecioEntry.Text = "";

        CargarProductos();
    }

    private void EliminarProducto(object sender, EventArgs e)
    {
        var swipeItem = sender as SwipeItem;
        var producto = swipeItem?.BindingContext as Producto;

        if (producto != null)
        {
            App.Database.DeleteProducto(producto);
            CargarProductos();
        }
    }
}
