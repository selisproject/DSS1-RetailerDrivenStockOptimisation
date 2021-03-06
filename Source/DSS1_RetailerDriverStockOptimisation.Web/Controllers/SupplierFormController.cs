// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using AppCode;
using DSS1_RetailerDriverStockOptimisation.BO;
using DSS1_RetailerDriverStockOptimisation.UI.ViewModels.SupplierForm;
using Identity = zAppDev.DotNet.Framework.Identity;
using log4net;
using Newtonsoft.Json;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using zAppDev.DotNet.Framework.Configuration;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity.Model;
using zAppDev.DotNet.Framework.Linq;
using zAppDev.DotNet.Framework.Mvc;
using zAppDev.DotNet.Framework.Utilities;

namespace DSS1_RetailerDriverStockOptimisation.UI.Controllers.SupplierForm
{

    [RoutePrefix("SupplierForm")]
    public class SupplierFormController : ControllerBase<SupplierFormViewModel, SupplierFormViewModelDTO>
    {

        /*<Form:SupplierForm:0/>*/
        public SupplierFormController()
        {
            _logger = log4net.LogManager.GetLogger(typeof(SupplierFormController));
            if (ViewModelDTOBase.DTOHelper == null)
            {
                ViewModelDTOBase.DTOHelper = new DTOHelper();
            }
        }

        protected override void ViewModelLoaded()
        {
            var masterViewModel = new DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel
            {
                Title = model.Title
            };
            _parentController = new MasterPage.MasterPageController(masterViewModel);
            _parentController.IsDirty = IsDirty;
        }

        public void SetModel(SupplierFormViewModel m)
        {
            @model = m;
        }


        public override void CommitAllFiles()
        {
        }

        public override void CommitAllFilesLegacy()
        {
        }

        public override void ClearPendingFiles()
        {
        }






        [HttpGet]

        [Route("GetViewDTO")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ContentResult GetViewDTO(int hash)
        {
            return Content(GetViewFromViewDTOsDicSerialized(hash));
        }

        [HttpPost]

        [Route("UpdateInstance")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult UpdateInstance()
        {
            return PrepareUpdateInstanceResult(typeof(SupplierFormViewModel));
        }

        [HttpPost]

        [Route("_Raise")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult _Raise()
        {
            return _RaiseEvent();
        }


        [HttpGet]
        [Route("DownloadFileByPath")]
        [CustomControllerActionFilter(HasDefaultResultView=true)]
        public FileContentResult DownloadFileByPath(string path, string defaultPath = null)
        {
            if (IdentityHelper.GetCurrentIdentityUser() == null) return null;
            if (string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(defaultPath))
            {
                throw new ApplicationException("Please provide a path.");
            }
            return FileHelper.PendingDownloadInstance.DownloadByPath(path, defaultPath);
        }




        #region Controller Actions
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="AddSupplier", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("AddSupplier")]
        public ActionResult AddSupplier()

        {
            @model = new SupplierFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_SupplierForm"] = "AddSupplier";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="AddSupplier", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_AddSupplier")]
        public ActionResult _API_AddSupplier()

        {
            @model = new SupplierFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_SupplierForm"] = "AddSupplier";
            PushToHistory();
            var _masterController = new DSS1_RetailerDriverStockOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteAddSupplier();
            return redirectInfo;
        }

        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="EditSupplier", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("EditSupplier/{*id:int?}")]
        public ActionResult EditSupplier(int? id)

        {
            @model = new SupplierFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_SupplierForm"] = "EditSupplier";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="EditSupplier", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_EditSupplier/{*id:int?}")]
        public ActionResult _API_EditSupplier(int? id)

        {
            @model = new SupplierFormViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_SupplierForm"] = "EditSupplier";
            PushToHistory();
            var _masterController = new DSS1_RetailerDriverStockOptimisation.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteEditSupplier(id);
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, CausesValidation=true, ActionName="SaveSupplier", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("SaveSupplier")]
        public ActionResult SaveSupplier()

        {
            var _data = _LoadViewModel();
            var _failedValidationsResult = GetFailedDataValidationsResult();
            if (_failedValidationsResult != null) return _failedValidationsResult;
            var redirectInfo = ExecuteSaveSupplier();
            return redirectInfo;
        }

        [CustomControllerActionFilter(LogEnabled=true, ActionName="DeleteSupplier", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("DeleteSupplier")]
        public ActionResult DeleteSupplier()

        {
            var _data = _LoadViewModel();
            var redirectInfo = ExecuteDeleteSupplier();
            return redirectInfo;
        }

        #endregion
        #region Controller Actions Implementation
        /*<ControllerActionImplementation:AddSupplier:1/>*/
        public ActionResult ExecuteAddSupplier()
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.Title = BaseViewPage<string>.GetResourceValue("SupplierForm", "RES_PAGETITLE_AddSupplier").ToString();
            return _result;
        }
        /*<ControllerActionImplementation:EditSupplier:1/>*/
        public ActionResult ExecuteEditSupplier(int? id)
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DSS1_RetailerDriverStockOptimisation.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.Supplier =  new DSS1_RetailerDriverStockOptimisation.DAL.Repository().GetById<DSS1_RetailerDriverStockOptimisation.BO.Supplier>(id);
            @model.Title = BaseViewPage<string>.GetResourceValue("SupplierForm", "RES_PAGETITLE_EditSupplier").ToString();
            return _result;
        }
        /*<ControllerActionImplementation:SaveSupplier:1/>*/
        public ActionResult ExecuteSaveSupplier()
        {
            ActionResult _result = null;
            new DSS1_RetailerDriverStockOptimisation.DAL.Repository().Save<DSS1_RetailerDriverStockOptimisation.BO.Supplier>(@model.Supplier);
            @model.Title = BaseViewPage<string>.GetResourceValue("SupplierForm", "RES_PAGETITLE_SaveSupplier").ToString();
            _result = CloseForm();
            return _result;
        }
        /*<ControllerActionImplementation:DeleteSupplier:1/>*/
        public ActionResult ExecuteDeleteSupplier()
        {
            ActionResult _result = null;
            new DSS1_RetailerDriverStockOptimisation.DAL.Repository().DeleteSupplier(@model.Supplier);
            @model.Title = BaseViewPage<string>.GetResourceValue("SupplierForm", "RES_PAGETITLE_DeleteSupplier").ToString();
            _result = CloseForm();
            return _result;
        }
        #endregion

        public override ActionResult PreActionFilterHook(bool causesValidation, bool listenToEvent, string actionName)
        {
            System.Web.HttpContext.Current.Items["_currentControllerAction"] = actionName;
            if (listenToEvent) return null;
            return null;
        }
        public override ActionResult PostActionFilterHook(bool hasDefaultResultView, bool fillDropDownInitialValues = false)
        {
            if (HasClientResponse())
            {
                viewDTO.ClientResponse = GetClientResponse();
            }
            else
            {
                var _modelDTO = new SupplierFormViewModelDTO(@model);
                viewDTO.Model = _modelDTO;
            }
            if (!hasDefaultResultView)
            {
                var __result = Json(new
                {
                    Type = "Data",Data = viewDTO.Serialize()
                }, JsonRequestBehavior.AllowGet);
                __result.MaxJsonLength = int.MaxValue;
                return __result;
            }
            return View("SupplierForm");
        }

        #region Data Validations


        private ActionResult GetFailedDataValidationsResult()
        {
            try
            {
                RunDataValidations();
                if (!viewDTO.DataValidationsHaveFailed) return null;
                var __result = Json(new
                {
                    Type = "RuleEvaluation",Data = viewDTO.Serialize()
                }, JsonRequestBehavior.AllowGet);
                __result.MaxJsonLength = int.MaxValue;
                return __result;
            }
            catch (Exception e)
            {
                _logger.Error("!!! DANGER: Error while evaluating Data Validations !!!", e);
                log4net.LogManager.GetLogger(this.GetType()).Error("Form: SupplierForm, Action: " + System.Web.HttpContext.Current.Items["_currentControllerAction"], e);
                //throw;
                return null;
            }
        }
        public List<RuleResult> RunDataValidations()
        {
            var masterPageDataValidations = (_parentController as Controllers.MasterPage.MasterPageController).RunDataValidations();
            if (masterPageDataValidations?.Any() == true)
            {
                viewDTO.RuleEvaluations.DataValidations.AddRange(masterPageDataValidations);
            }
            return viewDTO.RuleEvaluations.DataValidations;
        }

        #endregion
    }
}
