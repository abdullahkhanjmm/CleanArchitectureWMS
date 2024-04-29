using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using WMS.Domain.Warehouse;

namespace WMS.Application.Warehouse.Queries.GetWarehouse
{
    public record GetWarehouseQuery(Guid Id) : IRequest<WareHouse>;
}
