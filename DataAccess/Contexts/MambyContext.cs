using DataAccess.Identity.Model;
using Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public class MambyContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public MambyContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardLine> CardLines { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Command> Commands  { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SalesDetail { get; set; }
    }
}
