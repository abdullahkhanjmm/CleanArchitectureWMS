using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WMS.Application.Common.Interface;
using WMS.Domain.Warehouse;

namespace WMS.Infrastructure.Common.Persistance
{
    public class WmsDbContext:DbContext,IUnitofWork
    {
        public WmsDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<WareHouse> Warehouse { get; set; } = null!;
        public async Task CommitChangesAsync()
        {
            await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
