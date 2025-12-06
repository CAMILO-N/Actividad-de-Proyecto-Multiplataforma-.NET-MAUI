namespace AppEmpresarial;

public partial class App : Application
{
    public static DatabaseService Database { get; private set; }
    public static string UsuarioActual { get; set; } = "";

    public App()
    {
        InitializeComponent();

        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "appempresarial.db3");
        Database = new DatabaseService(dbPath);

        MainPage = new NavigationPage(new LoginPage());
    }
}
