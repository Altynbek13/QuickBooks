using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Bill> Bill{ get; set; }
        public DbSet<Check> Check { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<ItemSalesTax> ItemSalesTax { get; set; }
    }
}