using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMS.Application.Services;
using WMS.Application.Warehouse.Commands.CreateWarehouse;
using WMS.Application.Warehouse.Queries.GetWarehouse;
using WMS.Contracts.Warehouse;
using WMS.Domain.Warehouse;

namespace WMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        //private readonly IWareHouseWriteService _warehouseService;
        private readonly ISender _mediator;

        //public WarehouseController(IWareHouseWriteService warehouseService, IMediator mediator)
        //{
        //    _warehouseService = warehouseService;
        //}
        public WarehouseController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Warehouse(CreateWarehouseRequest request)
        {
            var command = new CreateWarehouseCommand(request.WarehouseName,request.Type, request
                .AdminId);
             
            var warehouse =await _mediator.Send(command);
            
            var response = new WareHouseResponse(warehouse.Id, request.WarehouseName,request.Type);
            //var warehouse = _warehouseService.CreateWarehouse(request.WarehouseName,request.Type.ToString(),request.AdminId);
            //var warehouseResponse = new WareHouseResponse(warehouse, request.WarehouseName);

            return Ok(response);
        }
        [HttpGet("{warehouseId:guid}")]
        public async Task<IActionResult> GetWarehouse(Guid warehouseId)
        {
            var query = new GetWarehouseQuery(warehouseId);

            var warehouse = await _mediator.Send(query);
            if (warehouse is null)
                return NotFound("No Warehouse Found with ID");
            var response = new WareHouseResponse(warehouse.Id, warehouse.name,warehouse.WareHousetype);

            return Ok(response);
        }
        [HttpDelete("{warehouseId:guid}")]
        public async Task<IActionResult> DeleteWarehouse(Guid warehouseId)
        {
            //var query = new DeleteWarehouseCommand(warehouseId);

            //var warehouse = await _mediator.Send(query);
            //if (warehouse is null)
            //    return NotFound("No Warehouse Found with ID");
            //var response = new WareHouseResponse(warehouse.Id, warehouse.name, warehouse.WareHousetype);

            //return Ok(response);
            return Ok();
        }
    }
}
