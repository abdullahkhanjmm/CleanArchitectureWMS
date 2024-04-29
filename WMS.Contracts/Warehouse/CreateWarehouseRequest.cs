using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Contracts.Warehouse
{
    public record CreateWarehouseRequest(WareHouseType Type,string WarehouseName, Guid AdminId);
}
