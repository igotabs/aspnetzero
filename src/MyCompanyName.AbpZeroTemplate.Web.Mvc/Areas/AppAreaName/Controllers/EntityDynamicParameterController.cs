using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.DynamicEntityParameters;
using Microsoft.AspNetCore.Mvc;
using MyCompanyName.AbpZeroTemplate.Authorization;
using MyCompanyName.AbpZeroTemplate.DynamicEntityParameters;
using MyCompanyName.AbpZeroTemplate.Web.Areas.AppAreaName.Models.EntityDynamicParameters;
using MyCompanyName.AbpZeroTemplate.Web.Controllers;

namespace MyCompanyName.AbpZeroTemplate.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_EntityDynamicParameters)]
    public class EntityDynamicParameterController : AbpZeroTemplateControllerBase
    {
        private readonly IDynamicParameterAppService _dynamicParameterAppService;
        private readonly IDynamicEntityParameterDefinitionManager _dynamicEntityParameterDefinitionManager;

        public EntityDynamicParameterController(
            IDynamicParameterAppService dynamicParameterAppService,
            IDynamicEntityParameterDefinitionManager dynamicEntityParameterDefinitionManager
            )
        {
            _dynamicParameterAppService = dynamicParameterAppService;
            _dynamicEntityParameterDefinitionManager = dynamicEntityParameterDefinitionManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AbpMvcAuthorize(AppPermissions.Pages_Administration_EntityDynamicParameters_Create)]
        public async Task<IActionResult> CreateModal()
        {
            var model = new CreateEntityDynamicParameterViewModel()
            {
                DynamicParameters = (await _dynamicParameterAppService.GetAll()).Items.ToList(),
                AllEntities = _dynamicEntityParameterDefinitionManager.GetAllEntities()
            };

            return PartialView("_CreateModal", model);
        }
    }
}