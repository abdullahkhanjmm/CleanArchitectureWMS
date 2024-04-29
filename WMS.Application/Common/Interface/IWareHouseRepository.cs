using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Domain.Warehouse;

namespace WMS.Application.Common.Interface
{
    public interface IWareHouseRepository
    {
        Task AddWarehouseAsync(WareHouse warehouse);
        Task<WareHouse> GetByIdAsync(Guid requestId);
    }
}
