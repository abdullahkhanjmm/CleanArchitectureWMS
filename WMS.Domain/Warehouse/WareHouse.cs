using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMS.Contracts.Warehouse;

namespace WMS.Domain.Warehouse
{
    public class WareHouse
    {
        private readonly Guid _adminId;
        public Guid Id { get; private set; }
        public string name { get; private set; }
        public WareHouseType WareHousetype { get; private set; }

        public WareHouse(WareHouseType type,string Name, Guid adminId,Guid? id = null)
        {
            WareHousetype = type;
            name = Name;
            _adminId = adminId;
            Id = id ?? Guid.NewGuid();
        }

        private WareHouse()
        {

        }

    }
}
