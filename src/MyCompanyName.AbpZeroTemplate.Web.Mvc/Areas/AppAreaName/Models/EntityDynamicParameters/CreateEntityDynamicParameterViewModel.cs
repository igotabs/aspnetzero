using System.Collections.Generic;
using MyCompanyName.AbpZeroTemplate.DynamicEntityParameters.Dto;

namespace MyCompanyName.AbpZeroTemplate.Web.Areas.AppAreaName.Models.EntityDynamicParameters
{
    public class CreateEntityDynamicParameterViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicParameterDto> DynamicParameters { get; set; }
    }
}
