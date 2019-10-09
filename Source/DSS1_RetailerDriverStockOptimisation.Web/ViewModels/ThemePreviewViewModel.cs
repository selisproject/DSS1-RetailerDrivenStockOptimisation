// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DSS1_RetailerDriverStockOptimisation.BO;
using DSS1_RetailerDriverStockOptimisation.UI.Controllers.ThemePreview;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPage;
using DSS1_RetailerDriverStockOptimisation.UI.Controllers.MasterPage;
namespace DSS1_RetailerDriverStockOptimisation.UI.ViewModels.ThemePreview
{
    public class ThemePreviewViewModel : MasterPageViewModel
    {
        public List<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation> Ops;
        public DateTime? JustDate;
        public string JustString;
        public string AnImageUrl;
        public int? JustAnInt;
        public List<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser> Users;
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>> DropdownBoxSelectedItems;
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>> DropdownBox1SelectedItems;
        public List<SelectedItemInfo<string>> OptionButtonSelectedItems;
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>> ChartSelectedItems;
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>> NewMapSelectedItems;
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>> Table2SelectedItems;
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>> ListSelectedItems;
        public List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>> PickListSelectedItems;


        public ThemePreviewViewModel()
        {
            Ops = new List<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>();
            Users = new List<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>();
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
            if (Ops != null)
            {
                foreach (var item in Ops)
                {
                    if (manager.Session.Contains(item))
                    {
                        manager.Session.Evict(item);
                    }
                }
            }
            if (Users != null)
            {
                foreach (var item in Users)
                {
                    if (manager.Session.Contains(item))
                    {
                        manager.Session.Evict(item);
                    }
                }
            }
        }

    }


    [OriginalType(typeof(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.ThemePreview.ThemePreviewViewModel))]
    public class ThemePreviewViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DSS1_RetailerDriverStockOptimisation.UI.ViewModels.ThemePreview.ThemePreviewViewModel>
    {

        [JsonConstructor]
        public ThemePreviewViewModelDTO() { }
        public ThemePreviewViewModelDTO(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.ThemePreview.ThemePreviewViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            Ops = original.Ops?.Select(x => new Ops_ApplicationOperationDTO(x)).ToList();
            JustDate = original.JustDate;
            JustString = original.JustString;
            AnImageUrl = original.AnImageUrl;
            JustAnInt = original.JustAnInt;
            Users = original.Users?.Select(x => new Users_ApplicationUserDTO(x)).ToList();
            DropdownBoxSelectedItemKeys = original.DropdownBoxSelectedItems == null
                                          ? null
                                          : original.DropdownBoxSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            DropdownBox1SelectedItemKeys = original.DropdownBox1SelectedItems == null
                                           ? null
                                           : original.DropdownBox1SelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            OptionButtonSelectedItemKeys = original.OptionButtonSelectedItems == null
                                           ? null
                                           : original.OptionButtonSelectedItems.Select(x => new SelectedItemInfo<string>(x.SelectedItems.Select(y => y).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            ChartSelectedItemKeys = original.ChartSelectedItems == null
                                    ? null
                                    : original.ChartSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            NewMapSelectedItemKeys = original.NewMapSelectedItems == null
                                     ? null
                                     : original.NewMapSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            Table2SelectedItemKeys = original.Table2SelectedItems == null
                                     ? null
                                     : original.Table2SelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            ListSelectedItemKeys = original.ListSelectedItems == null
                                   ? null
                                   : original.ListSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            PickListSelectedItemKeys = original.PickListSelectedItems == null
                                       ? null
                                       : original.PickListSelectedItems.Select(x => new SelectedItemInfo<int?>(x.SelectedItems.Select(y => y.Id).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
        public List<Ops_ApplicationOperationDTO> Ops;
        public DateTime? JustDate;
        public string JustString;
        public string AnImageUrl;
        public int? JustAnInt;
        public List<Users_ApplicationUserDTO> Users;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.ThemePreview.ThemePreviewViewModel).FullName;
        public List<SelectedItemInfo<int?>> DropdownBoxSelectedItemKeys;
        public List<SelectedItemInfo<int?>> DropdownBox1SelectedItemKeys;
        public List<SelectedItemInfo<string>> OptionButtonSelectedItemKeys;
        public List<SelectedItemInfo<int?>> ChartSelectedItemKeys;
        public List<SelectedItemInfo<int?>> NewMapSelectedItemKeys;
        public List<SelectedItemInfo<int?>> Table2SelectedItemKeys;
        public List<SelectedItemInfo<int?>> ListSelectedItemKeys;
        public List<SelectedItemInfo<int?>> PickListSelectedItemKeys;

        public new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.ThemePreview.ThemePreviewViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DSS1_RetailerDriverStockOptimisation.UI.ViewModels.ThemePreview.ThemePreviewViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.ThemePreview.ThemePreviewViewModel();
        }
        new  public DSS1_RetailerDriverStockOptimisation.UI.ViewModels.ThemePreview.ThemePreviewViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.ThemePreview.ThemePreviewViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DSS1_RetailerDriverStockOptimisation.UI.ViewModels.ThemePreview.ThemePreviewViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.Ops = Ops == null
                           ? null
                           : Ops.Select(q => q.Convert()).ToList();
            original.JustDate = JustDate;
            original.JustString = JustString;
            original.AnImageUrl = AnImageUrl;
            original.JustAnInt = JustAnInt;
            original.Users = Users == null
                             ? null
                             : Users.Select(q => q.Convert()).ToList();
            original.DropdownBoxSelectedItems = DropdownBoxSelectedItemKeys == null
                                                ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>>()
                                                : DropdownBoxSelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(x.SelectedItems.Select(y => ViewModels.ThemePreview.ApplicationOperationDataSet_ApplicationOperationDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            original.DropdownBox1SelectedItems = DropdownBox1SelectedItemKeys == null
                                                 ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>>()
                                                 : DropdownBox1SelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(x.SelectedItems.Select(y => ViewModels.ThemePreview.ApplicationOperationDataSet_ApplicationOperationDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            original.OptionButtonSelectedItems = OptionButtonSelectedItemKeys == null
                                                 ? new List<SelectedItemInfo<string>>()
                                                 : OptionButtonSelectedItemKeys.Select(x => new SelectedItemInfo<string>(x.SelectedItems.Select(y => y).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            original.ChartSelectedItems = ChartSelectedItemKeys == null
                                          ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>>()
                                          : ChartSelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(x.SelectedItems.Select(y => ViewModels.ThemePreview.ApplicationOperationDataSet_ApplicationOperationDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            original.NewMapSelectedItems = NewMapSelectedItemKeys == null
                                           ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>>()
                                           : NewMapSelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(x.SelectedItems.Select(y => ViewModels.ThemePreview.ApplicationOperationDataSet_ApplicationOperationDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            original.Table2SelectedItems = Table2SelectedItemKeys == null
                                           ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>>()
                                           : Table2SelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(x.SelectedItems.Select(y => ViewModels.ThemePreview.ApplicationOperationDataSet_ApplicationOperationDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            original.ListSelectedItems = ListSelectedItemKeys == null
                                         ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>>()
                                         : ListSelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(x.SelectedItems.Select(y => ViewModels.ThemePreview.ApplicationOperationDataSet_ApplicationOperationDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
            original.PickListSelectedItems = PickListSelectedItemKeys == null
                                             ? new List<SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>>()
                                             : PickListSelectedItemKeys.Select(x => new SelectedItemInfo<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(x.SelectedItems.Select(y => ViewModels.ThemePreview.ApplicationOperationDataSet_ApplicationOperationDTO.GetModelByKey(y)).ToList(), x.Indexes, x.FullRecordsetSelected)).ToList();
        }
    }

    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation))]
    public class Ops_ApplicationOperationDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>
    {

        [JsonConstructor]
        public Ops_ApplicationOperationDTO() { }
        public Ops_ApplicationOperationDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.Id as object;
            Id = original.Id;
            IsAvailableToAnonymous = original.IsAvailableToAnonymous;
            Name = original.Name;
            ParentControllerName = original.ParentControllerName;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public bool IsAvailableToAnonymous;
        public string Name;
        public string ParentControllerName;
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation).FullName;
        public override List<string> _baseClasses => null;
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = int.Parse(rawKey);
            if (parsedKey == default(int) || Equals(parsedKey, default(int)))
            {
                return new zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation();
            }
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation original)
        {
            if (original == null) return;
            original.Id = Id ?? 0;
            original.IsAvailableToAnonymous = IsAvailableToAnonymous;
            original.Name = Name;
            original.ParentControllerName = ParentControllerName;
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static Ops_ApplicationOperationDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(parsedKey, true);
            if(foundEntry != null)
            {
                return new Ops_ApplicationOperationDTO(foundEntry);
            }
            return null;
        }
    }

    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser))]
    public class Users_ApplicationUserDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>
    {

        [JsonConstructor]
        public Users_ApplicationUserDTO() { }
        public Users_ApplicationUserDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            _key = original.UserName as object;
            UserName = original.UserName;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            _clientKey = DTOHelper.GetClientKey(original, UserName);
        }
        public string UserName;
        public new object _key
        {
            get;
            set;
        }
        public string _versionTimestamp;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser).FullName;
        public override List<string> _baseClasses => null;
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationUser GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            if (_key == null) return null;
            var rawKey = _key.ToString();
            var parsedKey = (rawKey);
            if (parsedKey == default(string) || Equals(parsedKey, default(string)))
            {
                return new zAppDev.DotNet.Framework.Identity.Model.ApplicationUser();
            }
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationUser Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUser();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser original)
        {
            if (original == null) return;
            original.UserName = UserName ?? "";
            original.VersionTimestamp = string.IsNullOrEmpty(this._versionTimestamp) ? null : BitConverter.GetBytes(Int64.Parse(this._versionTimestamp));
        }
        public static Users_ApplicationUserDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = (rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, true);
            if(foundEntry != null)
            {
                return new Users_ApplicationUserDTO(foundEntry);
            }
            return null;
        }
    }

    #region Unbound Datasource DTOS
    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation))]
    public class ApplicationOperationDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>
    {
        public  string _runtimeType;
        public int? Id;
        public new object _key
        {
            get;
            set;
        }
        public bool IsAvailableToAnonymous;
        public string Name;
        public string ParentControllerName;


        [JsonConstructor]
        public ApplicationOperationDTO() : base() {}
        public  static ApplicationOperationDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = int.Parse(rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new ThemePreviewController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new ApplicationOperationDTO(foundEntry);
            }
            return null;
        }
        public ApplicationOperationDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, Id);
        }
        public ApplicationOperationDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationOperation original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.Id == 0) ? original._GetUniqueIdentifier() as object : original.Id as object;
            _runtimeType = original?.GetType().FullName;
            Id = original.Id;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
            IsAvailableToAnonymous = original.IsAvailableToAnonymous;
            Name = original.Name;
            ParentControllerName = original.ParentControllerName;
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
            model.IsAvailableToAnonymous = IsAvailableToAnonymous;
            model.Name = Name;
            model.ParentControllerName = ParentControllerName;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }



    #endregion

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
        public string Name;
        public string ParentControllerName;
        public bool IsAvailableToAnonymous;
        public bool IsAvailableToAllAuthorizedUsers;
        public string Type;


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
                    var controller = new ThemePreviewController();
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
            Name = original.Name;
            ParentControllerName = original.ParentControllerName;
            IsAvailableToAnonymous = original.IsAvailableToAnonymous;
            IsAvailableToAllAuthorizedUsers = original.IsAvailableToAllAuthorizedUsers;
            Type = original.Type;
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
            model.Name = Name;
            model.ParentControllerName = ParentControllerName;
            model.IsAvailableToAnonymous = IsAvailableToAnonymous;
            model.IsAvailableToAllAuthorizedUsers = IsAvailableToAllAuthorizedUsers;
            model.Type = Type;
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }

    [OriginalType(typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser))]
    [DataSetDTO]
    public class CalendarSet_ApplicationUserDTO : ViewModelDTOBase, IViewModelDTO<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>
    {
        public override string _originalTypeClassName => typeof(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser).FullName;
        public string _versionTimestamp;
        public  string _runtimeType;
        public string UserName;
        public new object _key
        {
            get;
            set;
        }


        [JsonConstructor]
        public CalendarSet_ApplicationUserDTO() : base() {}
        public  static CalendarSet_ApplicationUserDTO GetInstance(object key, string jbID)
        {
            if (key == null) return null;
            var rawKey = key.ToString();
            var parsedKey = (rawKey);
            var foundEntry = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, false);
            if(foundEntry == null && !string.IsNullOrWhiteSpace(jbID))
            {
                if(int.TryParse(rawKey, out int _uniqueKey))
                {
                    var controller = new ThemePreviewController();
                    var method = controller.GetType().GetMethod($"Get_{jbID}_DatasourceQueryable");
                    var records = method.Invoke(controller, new object[] { null }) as IQueryable<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>;
                    foundEntry = records.Where(c => c._GetUniqueIdentifier() == _uniqueKey).FirstOrDefault();
                }
            }
            if(foundEntry != null)
            {
                return new CalendarSet_ApplicationUserDTO(foundEntry);
            }
            return null;
        }
        public CalendarSet_ApplicationUserDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser original, bool assignClientKey) : this(original)
        {
            _clientKey = DTOHelper.GetClientKey(original, UserName);
        }
        public CalendarSet_ApplicationUserDTO(zAppDev.DotNet.Framework.Identity.Model.ApplicationUser original)
        {
            if(original == null) throw new ApplicationException(BaseViewPage<object>.GetResourceValue("GlobalResources", "RES_DATASOURCE_Null_Value_In_Resultset", null, "The resultset of your DataSource contains null values."));
            _key = (original.UserName == "") ? original._GetUniqueIdentifier() as object : original.UserName as object;
            _runtimeType = original?.GetType().FullName;
            if (original.VersionTimestamp != null && original.VersionTimestamp.Length > 0)
            {
                _versionTimestamp = BitConverter.ToInt64(original.VersionTimestamp, 0).ToString();
            }
            UserName = original.UserName;
            if (!DTOHelper.SeenDTOInstances.ContainsKey(original))
            {
                DTOHelper.SeenDTOInstances.Add(original, this);
            }
        }

        public static zAppDev.DotNet.Framework.Identity.Model.ApplicationUser GetModelByKey(object _key)
        {
            var rawKey = _key.ToString();
            var parsedKey = (rawKey);
            return new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, false);
        }
        public zAppDev.DotNet.Framework.Identity.Model.ApplicationUser Convert()
        {
            var model = new zAppDev.DotNet.Framework.Identity.Model.ApplicationUser();
            if (_key != null && _key.ToString() != "")
            {
                var rawKey = _key.ToString();
                var parsedKey = (rawKey);
                model = new DAL.Repository().GetById<zAppDev.DotNet.Framework.Identity.Model.ApplicationUser>(parsedKey, false) ?? model;
            }
            if (!DTOHelper.SeenModelInstances.ContainsKey(this))
            {
                DTOHelper.SeenModelInstances.Add(this, model);
            }
            model.UserName = UserName ?? "";
            DTOHelper.UpdateSeenModelInstances(this, model);
            return model;
        }

    }


    #endregion

}