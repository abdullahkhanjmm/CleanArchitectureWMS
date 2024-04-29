using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using WMS.Application.Common.Interface;
using WMS.Contracts.Warehouse;
using WMS.Domain.Warehouse;

namespace WMS.Application.Warehouse.Commands.CreateWarehouse
{
    public class CreateWarehouseCommandHandler : IRequestHandler<CreateWarehouseCommand,WareHouse>
    {
        private readonly IWareHouseRepository _warehouseRepository;
        private readonly IUnitofWork _unitofWork;

        public CreateWarehouseCommandHandler(IWareHouseRepository warehouseRepository, IUnitofWork unitofWork)
        {
            _warehouseRepository = warehouseRepository;
            _unitofWork = unitofWork;
        }

        public async Task<WareHouse> Handle(CreateWarehouseCommand request, CancellationToken cancellationToken)
        {
            //create warehouse
            //var warehouse = new WareHouse()
            //{
            //    Id=Guid.NewGuid(),
            //    name = request.WarehouseName,
            //    type = Enum.Parse<WareHouseType>(request.WarehouseType)
            //};
            var warehouse = new WareHouse(request.WarehouseType,request.WarehouseName, request.AdminId);

            //Add to database
            await _warehouseRepository.AddWarehouseAsync(warehouse);
            await _unitofWork.CommitChangesAsync();

            //return warehouse
            return warehouse;
        }
    }
}
