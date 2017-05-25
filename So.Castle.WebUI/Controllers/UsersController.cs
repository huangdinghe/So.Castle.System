using So.Castle.Core;
using So.Castle.Domain;
using So.Castle.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace So.Castle.WebUI.Controllers
{
    public class UsersController : BaseController
    {
        // GET: Users
        [HttpGet]
        public ActionResult Index()
        {
            IList<Users> users= Container.Instance.Resolve<IUsersService>().GetAll();
            return View(users);
        }
    }
}