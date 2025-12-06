using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AppEmpresarial;

public class DatabaseService
{
    private readonly SQLiteConnection _db;

    public DatabaseService(string dbPath)
    {
        _db = new SQLiteConnection(dbPath);
        _db.CreateTable<Usuario>();
        _db.CreateTable<Producto>();
        _db.CreateTable<Cliente>();
        _db.CreateTable<Venta>();
        _db.CreateTable<StockItem>();

        // Crear usuario por defecto
        if (_db.Table<Usuario>().Count() == 0)
        {
            _db.Insert(new Usuario { Username = "admin", Password = "1234" });
        }
    }

    // ----------------- USUARIOS ---------------------
    public Usuario? ValidarUsuario(string usuario, string clave)
    {
        return _db.Table<Usuario>()
                  .FirstOrDefault(u => u.Username == usuario && u.Password == clave);
    }

    // ----------------- PRODUCTOS ---------------------
    public List<Producto> GetProductos() => _db.Table<Producto>().ToList();
    public int AddProducto(Producto p) => _db.Insert(p);
    public int DeleteProducto(Producto p) => _db.Delete(p);

    // ----------------- CLIENTES ---------------------
    public List<Cliente> GetClientes() => _db.Table<Cliente>().ToList();
    public int AddCliente(Cliente c) => _db.Insert(c);
    public int DeleteCliente(Cliente c) => _db.Delete(c);

    // ----------------- VENTAS ---------------------
    public List<Venta> GetVentas() => _db.Table<Venta>().ToList();
    public int AddVenta(Venta v) => _db.Insert(v);
    public int DeleteVenta(Venta v) => _db.Delete(v);

    // ----------------- STOCK ---------------------
    public List<StockItem> GetStock() => _db.Table<StockItem>().ToList();
    public int AddStock(StockItem s) => _db.Insert(s);
    public int DeleteStock(StockItem s) => _db.Delete(s);
}
