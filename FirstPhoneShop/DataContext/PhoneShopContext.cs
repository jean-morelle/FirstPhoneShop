using FirstPhoneShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace FirstPhoneShop.DataContext
{
    public class PhoneShopContext : DbContext
    {
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public PhoneShopContext(DbContextOptions<PhoneShopContext> options):base(options)
        {
            
        }
        
    }
    
}
