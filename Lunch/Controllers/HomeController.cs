using Lunch.BAL.IService;
using Lunch.BAL.Service;
using Lunch.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lunch.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;
        private ILunchMenuService _lunchMenuService;
        public HomeController()
        {
            _userService = new UserService();
            _lunchMenuService = new LunchMenuService();
        }

        public ActionResult Index()
        {
            ViewBag.UserName = _userService.GetUserName(1);
            var LunchList = _lunchMenuService.GetAllType();
            HomeModel model = new HomeModel();
            model.Lunch = LunchList;
            model.LunchPlace = new List<string>() { "Colombo","Kandy"};
            model.Transport = LunchList; new List<string>() { "Colombo", "Kandy" };
            model.LeaveTime = new List<string>() { "5.00", "6.00" };
            return View(model);
        }
        [HttpPost]
        public ActionResult LunchSubmit(HomeModel model)
        {
            return View("IndexSubmit");
        }

        [HttpPost]
        public ActionResult TransportSubmit(HomeModel model)
        {
            return View("IndexSubmit");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}