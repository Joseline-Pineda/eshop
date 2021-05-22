using eshop.api.Models;
using Microsoft.EntityFrameworkCore;

namespace eshop.api.DataAccess
{
    //AppDbContext Cualquier nombre
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<ModoPago> ModoPagos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
    }
}