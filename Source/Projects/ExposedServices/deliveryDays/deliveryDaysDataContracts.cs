// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DSS1_RetailerDriverStockOptimisation.Services.deliveryDays.DataContracts
{
    public class DeliveryScheduleDTO
    {
        public int? LeadTime
        {
            get;
            set;
        }
        public int? Weekday
        {
            get;
            set;
        }
        public SupplierDTO Supplier
        {
            get;
            set;
        }
        public ItemDTO Item
        {
            get;
            set;
        }
        public WarehouseDTO Warehouse
        {
            get;
            set;
        }
    }

    public class SupplierDTO
    {
        public string Code
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
    }

    public class ItemDTO
    {
        public string SKU
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string UPC
        {
            get;
            set;
        }
    }

    public class WarehouseDTO
    {
        public int? Id
        {
            get;
            set;
        }
        public string Code
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
    }

    public class ResponseDTO
    {
        public string Status
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }
        public string Details
        {
            get;
            set;
        }
        public string Code
        {
            get;
            set;
        }
    }


}