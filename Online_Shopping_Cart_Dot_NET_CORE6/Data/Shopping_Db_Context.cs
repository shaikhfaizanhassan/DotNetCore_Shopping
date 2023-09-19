using Microsoft.EntityFrameworkCore;
using Online_Shopping_Cart_Dot_NET_CORE6.Models;

namespace Online_Shopping_Cart_Dot_NET_CORE6.Data
{
    public class Shopping_Db_Context : DbContext
    {
        public Shopping_Db_Context(DbContextOptions<Shopping_Db_Context>options):base(options) 
        { 
        }
        public DbSet<Admin> admins { get; set; }    
        public DbSet<Brand> brands { get; set; }    
        public DbSet<Category> categories { get; set; } 
        public DbSet<Product> products { get; set; }
        public DbSet<Invoice> invoices { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Shippment> shippments { get; set; }
        public DbSet<UserTb> userTbs { get; set; }
        public DbSet<FeedBack> feedBacks { get; set; }

    }
}
