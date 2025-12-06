namespace AppEmpresarial;

public partial class VentasPage : ContentPage
{
    public VentasPage()
    {
        InitializeComponent();
        CargarVentas();
    }

    private void CargarVentas()
    {
        VentasList.ItemsSource = App.Database.GetVentas();
    }

    private void AgregarVenta(object sender, EventArgs e)
    {
        string producto = ProductoEntry.Text?.Trim() ?? "";
        double total = 0;

        if (string.IsNullOrEmpty(producto))
        {
            DisplayAlert("Error", "Ingrese el nombre del producto", "OK");
            return;
        }

        if (!double.TryParse(TotalEntry.Text, out total))
        {
            DisplayAlert("Error", "Total inválido", "OK");
            return;
        }

        var nuevaVenta = new Venta
        {
            Producto = producto,
            Total = total
        };

        App.Database.AddVenta(nuevaVenta);

        ProductoEntry.Text = "";
        TotalEntry.Text = "";

        CargarVentas();
    }

    private void EliminarVenta(object sender, EventArgs e)
    {
        var swipeItem = sender as SwipeItem;
        var venta = swipeItem?.BindingContext as Venta;

        if (venta != null)
        {
            App.Database.DeleteVenta(venta);
            CargarVentas();
        }
    }
}
