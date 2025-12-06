using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace AppEmpresarial;

public class Venta
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Producto { get; set; }
    public double Total { get; set; }
}
