using Microsoft.EntityFrameworkCore;
using Services.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Model.Context
{
    public class ShopDBContetext : DbContext
    {
        public ShopDBContetext(DbContextOptions<ShopDBContetext> options) : base(options)
        {
        }
        public DbSet<Catogory> catogories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
