using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Issue6672.Controllers;

namespace Issue6672.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : Issue6672ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
