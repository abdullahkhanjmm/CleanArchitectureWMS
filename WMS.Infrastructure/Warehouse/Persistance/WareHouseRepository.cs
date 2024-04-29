using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Application.Common.Interface;
using WMS.Domain.Warehouse;
using WMS.Infrastructure.Common.Persistance;

namespace WMS.Infrastructure.Warehouse.Persistance
{
    public class WareHouseRepository:IWareHouseRepository
    {
        //private readonly static List<WareHouse> _wareHouses = new();
        private readonly WmsDbContext _dbContext;

        public WareHouseRepository(WmsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddWarehouseAsync(WareHouse warehouse)
        {
            await _dbContext.Warehouse.AddAsync(warehouse);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<WareHouse> GetByIdAsync(Guid requestId)
        {
            var warehouse = await _dbContext.Warehouse.FindAsync(requestId);
            return warehouse;
        }
    }
}
