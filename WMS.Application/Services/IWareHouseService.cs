﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Application.Services
{
    public interface IWareHouseWriteService
    {
        public Guid CreateWarehouse(string warehouseName,string warehouseType, Guid adminId);
    }
}
