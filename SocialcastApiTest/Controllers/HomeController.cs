using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SocialcastDataModel;
using SocialcastApi;
using SocialcastApiHelper;

namespace SocialcastApiTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Socialcast test site";
            var api = (CommonMethods)Session["SocialcastApi"];

            if (api != null)
            {
                List<UserProfile> UserProfiles = api.GetAllActiveUsers();
            }
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
