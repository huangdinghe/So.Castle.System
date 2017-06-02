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
    public class VideoController : Controller
    {
        // GET: Video
        public ActionResult Index()
        {
            IList<Video> video = Container.Instance.Resolve<IVideoService>().GetAll();
            return View(video);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Video video)
        {
            Container.Instance.Resolve<IVideoService>().Create(video);
            return View(video);
        }
    }
}