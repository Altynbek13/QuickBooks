using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Bill> Bill { get; set; }
        public DbSet<Check> Check { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<ItemSalesTax> ItemSalesTax { get; set; }
        public int SaveChanges();
    }
}
