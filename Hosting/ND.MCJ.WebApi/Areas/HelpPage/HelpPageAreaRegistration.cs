using System.Web.Http;
using System.Web.Mvc;

namespace NC.MCJ.WebApi.Areas.HelpPage
{
    public class HelpPageAreaRegistration : AreaRegistration
    {
        public override string AreaName { get { return "HelpPage"; } }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "HelpPage_Default",
                "Help/{action}/{apiId}",
                new { controller = "Help", action = "Docs", apiId = UrlParameter.Optional });
            HelpPageConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}