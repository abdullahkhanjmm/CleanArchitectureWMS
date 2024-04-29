using MediatR;
using WMS.Application.Common.Interface;
using WMS.Domain.Warehouse;

namespace WMS.Application.Warehouse.Queries.GetWarehouse
{

    public class GetWarehouseQueryHandler : IRequestHandler<GetWarehouseQuery, WareHouse>
    {
        private readonly IWareHouseRepository _warehouseRepository;

        public GetWarehouseQueryHandler(IWareHouseRepository warehouseRepository)
        {
            _warehouseRepository = warehouseRepository;
        }

        public async Task<WareHouse> Handle(GetWarehouseQuery request, CancellationToken cancellationToken)
        {
            var warehouse = await _warehouseRepository.GetByIdAsync(request.Id);
            return warehouse;
        }
    }
}
