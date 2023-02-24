using Microsoft.AspNetCore.Mvc;
using MyUmbraco10.Models;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace MyUmbraco10.Controllers
{
    public class ASIAccountSurfaceController : SurfaceController
    {
        private IConfiguration _configuration;
        public ASIAccountSurfaceController(IConfiguration config,
                                        IUmbracoContextAccessor umbracoContextAccessor,
                                        IUmbracoDatabaseFactory databaseFactory,
                                        ServiceContext services,
                                        AppCaches appCaches,
                                        IProfilingLogger profilingLogger,
                                        IPublishedUrlProvider publishedUrlProvider)
            : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)

        {
            _configuration = config;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(ASIAccountViewModel login)
        {
            return new RedirectResult("/");
        }
    }
}
