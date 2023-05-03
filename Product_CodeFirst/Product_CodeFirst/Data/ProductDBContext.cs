using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Product_CodeFirst.Models;

namespace Product_CodeFirst.Data
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext (DbContextOptions<ProductDBContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
