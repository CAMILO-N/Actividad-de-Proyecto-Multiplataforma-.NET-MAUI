namespace AppEmpresarial;

public partial class StockPage : ContentPage
{
    public StockPage()
    {
        InitializeComponent();
        CargarStock();
    }

    private void CargarStock()
    {
        StockList.ItemsSource = App.Database.GetStock();
    }

    private void AgregarStock(object sender, EventArgs e)
    {
        string nombre = NombreEntry.Text?.Trim() ?? "";
        int cantidad = 0;

        if (string.IsNullOrEmpty(nombre))
        {
            DisplayAlert("Error", "Ingrese el nombre del producto", "OK");
            return;
        }

        if (!int.TryParse(CantidadEntry.Text, out cantidad))
        {
            DisplayAlert("Error", "Cantidad inválida", "OK");
            return;
        }

        var item = new StockItem
        {
            Nombre = nombre,
            Cantidad = cantidad
        };

        App.Database.AddStock(item);

        NombreEntry.Text = "";
        CantidadEntry.Text = "";

        CargarStock();
    }

    private void EliminarStock(object sender, EventArgs e)
    {
        var swipeItem = sender as SwipeItem;
        var item = swipeItem?.BindingContext as StockItem;

        if (item != null)
        {
            App.Database.DeleteStock(item);
            CargarStock();
        }
    }
}
