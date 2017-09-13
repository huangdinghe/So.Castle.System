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
        // GET: Users 返回视图
        [HttpGet]
        public ActionResult Index()
        {
            IList<Users> users = Container.Instance.Resolve<IUsersService>().GetAll();
            return View(users);
        }
        //返回json数据 返回用户数据
        [HttpGet]
        public JsonResult IndexJson()
        {
            Users userslist = null;
            IList<Users> users = Container.Instance.Resolve<IUsersService>().GetAll();
            if (users != null) userslist = users[0];
            return Json(new { usersname= userslist.users_name,password=userslist.password},JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult JsonTest(string json)
        {
            return Json("humo");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Users users)
        {
            Container.Instance.Resolve<IUsersService>().Create(users);
            return View(users);
        }
    }
}