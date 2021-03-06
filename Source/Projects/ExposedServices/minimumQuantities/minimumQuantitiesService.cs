// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Channels;
using System.Security.Permissions;
using System.Security.Principal;
using NHibernate;
using System.ServiceModel.Activation;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using DSS1_RetailerDriverStockOptimisation.Services.minimumQuantities.DataContracts;
using DSS1_RetailerDriverStockOptimisation.BO;
using AutoMapper;

namespace DSS1_RetailerDriverStockOptimisation.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class minimumQuantitiesService : IminimumQuantitiesService
    {
        public ResponseDTO Import(System.Collections.Generic.List<MinimumQuantityDTO> _minQuantities, string _RequestSourceIp, string _UserName)
        {
            InitializeMappers();
            try
            {
                var inputminQuantities = Mapper.Map<System.Collections.Generic.List<MinimumQuantityDTO>, System.Collections.Generic.List<DSS1_RetailerDriverStockOptimisation.BO.MinimumQuantity>>(_minQuantities);
                var _import = ImportImplementation(inputminQuantities);
                var result = Mapper.Map<DSS1_RetailerDriverStockOptimisation.BO.Response, ResponseDTO>(_import);
                return result;
            }
            catch (Exception @exception)
            {
                log4net.LogManager.GetLogger("minimumQuantities Service").Error(@exception);
                throw;
            }
        }


        private void InitializeMappers()
        {
            Mapper.CreateMap<ItemDTO, DSS1_RetailerDriverStockOptimisation.BO.Item>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.Item, ItemDTO>();
            Mapper.CreateMap<MinimumQuantityDTO, DSS1_RetailerDriverStockOptimisation.BO.MinimumQuantity>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.MinimumQuantity, MinimumQuantityDTO>();
            Mapper.CreateMap<ResponseDTO, DSS1_RetailerDriverStockOptimisation.BO.Response>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.Response, ResponseDTO>();
            Mapper.CreateMap<SupplierDTO, DSS1_RetailerDriverStockOptimisation.BO.Supplier>();
            Mapper.CreateMap<DSS1_RetailerDriverStockOptimisation.BO.Supplier, SupplierDTO>();
        }

        public static DSS1_RetailerDriverStockOptimisation.BO.Response ImportImplementation(System.Collections.Generic.List<DSS1_RetailerDriverStockOptimisation.BO.MinimumQuantity> minQuantities)
        {
            string message = "";
            foreach (var minQ in minQuantities ?? Enumerable.Empty<DSS1_RetailerDriverStockOptimisation.BO.MinimumQuantity>())
            {
                if ((minQ?.Item == null || minQ?.Supplier == null))
                {
                    message = message + (minQ?.Id ?? 0) + " ,";
                    continue;
                }
                var _var0 = minQ?.Item?.SKU;
                DSS1_RetailerDriverStockOptimisation.BO.Item existingItem = new DSS1_RetailerDriverStockOptimisation.DAL.Repository().GetAsQueryable<DSS1_RetailerDriverStockOptimisation.BO.Item>((s) => s.SKU == _var0)?.FirstOrDefault();
                var _var1 = minQ?.Supplier?.Code;
                DSS1_RetailerDriverStockOptimisation.BO.Supplier existingSupplier = new DSS1_RetailerDriverStockOptimisation.DAL.Repository().GetAsQueryable<DSS1_RetailerDriverStockOptimisation.BO.Supplier>((w) => w.Code == _var1)?.FirstOrDefault();
                if ((existingItem == null || existingSupplier == null))
                {
                    message = message + (minQ?.Id ?? 0) + " ,";
                    continue;
                }
                DSS1_RetailerDriverStockOptimisation.BO.MinimumQuantity newMinQuantity = new DSS1_RetailerDriverStockOptimisation.BO.MinimumQuantity();
                newMinQuantity.Supplier = existingSupplier;
                newMinQuantity.Country = (minQ?.Country ?? "");
                newMinQuantity.Item = existingItem;
                newMinQuantity.Quantity = (minQ?.Quantity ?? 0);
                new DSS1_RetailerDriverStockOptimisation.DAL.Repository().Save<DSS1_RetailerDriverStockOptimisation.BO.MinimumQuantity>(newMinQuantity);
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Info, "API",  DSS1_RetailerDriverStockOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Min Quantity: " + (minQ?.Quantity ?? 0) + " for item: " + (existingItem?.SKU ?? ""));
            }
            if (((((message == null || message == "")) == false)))
            {
                zAppDev.DotNet.Framework.Utilities.DebugHelper.Log(zAppDev.DotNet.Framework.Utilities.DebugMessageType.Warning, "API",  DSS1_RetailerDriverStockOptimisation.Hubs.EventsHub.RaiseDebugMessage, "Error message: " + message);
                return DSS1_RetailerDriverStockOptimisation.BO.ResponseExtensions.GenerateResponse("Failed", "Failed to import the stocks with Ids " + message, "", "-1");
            }
            return DSS1_RetailerDriverStockOptimisation.BO.ResponseExtensions.GenerateResponse("Succeed", "All entries imported successfully.", "", "1");
        }


    }
}