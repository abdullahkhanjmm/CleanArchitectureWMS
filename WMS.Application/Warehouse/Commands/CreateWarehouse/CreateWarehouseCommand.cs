using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using WMS.Contracts.Warehouse;
using WMS.Domain.Warehouse;

namespace WMS.Application.Warehouse.Commands.CreateWarehouse
{
    public record CreateWarehouseCommand(string WarehouseName,WareHouseType WarehouseType, Guid AdminId): IRequest<WareHouse>;
}
