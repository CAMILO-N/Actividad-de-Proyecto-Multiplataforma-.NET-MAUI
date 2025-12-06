namespace AppEmpresarial;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string usuario = UsuarioEntry.Text?.Trim();
        string clave = PasswordEntry.Text?.Trim();

        if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
        {
            await DisplayAlert("Error", "Ingrese usuario y contraseña", "OK");
            return;
        }

        var resultado = App.Database.ValidarUsuario(usuario, clave);

        if (resultado != null)
        {
            App.UsuarioActual = usuario;

            await Navigation.PushAsync(new MainPage());
        }
        else
        {
            await DisplayAlert("Error", "Credenciales incorrectas", "OK");
        }
    }
}
