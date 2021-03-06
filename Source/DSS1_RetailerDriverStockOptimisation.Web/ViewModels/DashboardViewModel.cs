// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS1_RetailerDriverStockOptimisation.BO;
using DSS1_RetailerDriverStockOptimisation.UI.Controllers.Dashboard;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPage;
using DSS1_RetailerDriverStockOptimisation.UI.Controllers.MasterPage;
namespace DSS1_RetailerDriverStockOptimisation.UI.ViewModels.Dashboard
{
    public class DashboardViewModel : MasterPageViewModel
    {
        public int? TotalUsers;
        public int? TotalOperations;
        public int? TotalPermissions;
        public DateTime? dateNow;
        public string ActiveUsername;
        public string Locale;
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>> ChartSelectedItems;
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>> Chart1SelectedItems;
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>> Chart11SelectedItems;


        public DashboardViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.Dashboard.DashboardViewModel))]
    public class DashboardViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS1_RetailerDriverStockOptimisation.UI.ViewModels.Dashboard.DashboardViewModel>
    {

        [JsonConstructor]
        public DashboardViewModelDTO() { }
        public DashboardViewModelDTO(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.Dashboard.DashboardViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            TotalUsers = original.TotalUsers;
            TotalOperations = original.TotalOperations;
            TotalPermissions = original.TotalPermissions;
            dateNow = original.dateNow;
            ActiveUsername = original.ActiveUsername;
            Locale = original.Locale;
            ChartSelectedItemKeys = original.ChartSelectedItems == null
                                    ? null
                                    : original.ChartSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            Chart1SelectedItemKeys = original.Chart1SelectedItems == null
                                     ? null
                                     : original.Chart1SelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            Chart11SelectedItemKeys = original.Chart11SelectedItems == null
                                      ? null
                                      : original.Chart11SelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public int? TotalUsers;
        public int? TotalOperations;
        public int? TotalPermissions;
        public DateTime? dateNow;
        public string ActiveUsername;
        public string Locale;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.Dashboard.DashboardViewModel).FullName;
        public List<SelectedItemInfo<int?>> ChartSelectedItemKeys;
        public List<SelectedItemInfo<int?>> Chart1SelectedItemKeys;
        public List<SelectedItemInfo<int?>> Chart11SelectedItemKeys;

        public new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.Dashboard.DashboardViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS1_RetailerDriverStockOptimisation.UI.ViewModels.Dashboard.DashboardViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.Dashboard.DashboardViewModel();
        }
        new  public DSS1_RetailerDriverStockOptimisation.UI.ViewModels.Dashboard.DashboardViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.Dashboard.DashboardViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.Dashboard.DashboardViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.TotalUsers = TotalUsers;
            original.TotalOperations = TotalOperations;
            original.TotalPermissions = TotalPermissions;
            original.dateNow = dateNow;
            original.ActiveUsername = ActiveUsername;
            original.Locale = Locale;
            original.ChartSelectedItems = ChartSelectedItemKeys == null
                                          ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>>()
                                          : ChartSelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(x.SelectedItems.Select(y => ViewModels.Dashboard.ApplicationOperationDataSet_ApplicationOperationDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            original.Chart1SelectedItems = Chart1SelectedItemKeys == null
                                           ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>>()
                                           : Chart1SelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(x.SelectedItems.Select(y => ViewModels.Dashboard.ApplicationOperationDataSet_ApplicationOperationDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            original.Chart11SelectedItems = Chart11SelectedItemKeys == null
                                            ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>>()
                                            : Chart11SelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(x.SelectedItems.Select(y => ViewModels.Dashboard.ApplicationOperationDataSet_ApplicationOperationDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }


    #region Datasource DTOs
    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation))]
    [DataSetDTO]
    public class ApplicationOperationDataSet_ApplicationOperationDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>
    {
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public string ParentControllerName;
        public bool IsAvailableToAllAuthorizedUsers;


        [JsonConstructor]
        public ApplicationOperationDataSet_ApplicationOperationDTO() : base() {}
        public  static ApplicationOperationDataSet_ApplicationOperationDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new DashboardController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new ApplicationOperationDataSet_ApplicationOperationDTO(foundEntry);
            }
            return null;
        }
        public ApplicationOperationDataSet_ApplicationOperationDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public ApplicationOperationDataSet_ApplicationOperationDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.Id == 0) ? original._GetUniqueIdentifier() as object : original.Id as object;
            _runtimeType = original?.GetType().FullName;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            Id = original.Id;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
            ParentControllerName = original.ParentControllerName;
            IsAvailableToAllAuthorizedUsers = original.IsAvailableToAllAuthorizedUsers;
        }

        public static zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation Convert()
        {
            var model = new zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            model.ParentControllerName = ParentControllerName;
            model.IsAvailableToAllAuthorizedUsers = IsAvailableToAllAuthorizedUsers;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationRole))]
    [DataSetDTO]
    public class ApplicationRoleDataSet_ApplicationRoleDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>
    {
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationRole).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }


        [JsonConstructor]
        public ApplicationRoleDataSet_ApplicationRoleDTO() : base() {}
        public  static ApplicationRoleDataSet_ApplicationRoleDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new DashboardController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new ApplicationRoleDataSet_ApplicationRoleDTO(foundEntry);
            }
            return null;
        }
        public ApplicationRoleDataSet_ApplicationRoleDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationRole original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public ApplicationRoleDataSet_ApplicationRoleDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationRole original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.Id == 0) ? original._GetUniqueIdentifier() as object : original.Id as object;
            _runtimeType = original?.GetType().FullName;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            Id = original.Id;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
        }

        public static zAppDev.DotNet.Framework.Identity.Model.ApplicationRole GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationRole Convert()
        {
            var model = new zAppDev.DotNet.Framework.Identity.Model.ApplicationRole();
            if (_key != null && _key.ToString() != "0")
            {
                var rawKey = _key.ToString();
                var parsedKey = int.Parse(rawKey);
                model = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationRole>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.Id = Id ?? 0;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    #endregion

}
