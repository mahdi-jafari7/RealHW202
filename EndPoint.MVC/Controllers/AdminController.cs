//using Domain.Core._01_Entities;
//using Domain.Core._02_Contracts.AppServices;
//using Microsoft.AspNetCore.Mvc;

//namespace EndPoint.MVC.Controllers
//{
//    public class AdminController : Controller
//    {
//        private static bool IsLogin = false;
//        IAdminAppService _adminAppService;
//        ICarInspectAppService _carInspectAppService;
//        public AdminController(IAdminAppService adminAppService, ICarInspectAppService carInspectAppService)
//        {
//            _adminAppService = adminAppService;
//            _carInspectAppService = carInspectAppService;
//        }
//        public IActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Login(string username,string password)
//        {
//            var islogin = _adminAppService.PasswordIsValid(username, password);

//            if (islogin)
//            {
//                SetUserLoggedIn();
//                return View("DashBoard");
//            }
//            else {
//                return View();
//            }
//        }

//        public IActionResult ListInspect()
//        {
//            if (IsUserLoggedIn())
//            {
//                var list = _carInspectAppService.GetAllCarInspections().ToList();
//                return View(list);
                
//            }
//            else
//            {
//                return RedirectToAction("Login", "Admin");
//            }
            
//        }

//       public IActionResult Confirm(int id)
//        {
//           _carInspectAppService.SetConfirm(id);
//            return RedirectToAction("ListInspect");
//        }
//        public IActionResult Cancell(int id)
//        {
//            _carInspectAppService.SetCancell(id);

//            return RedirectToAction("ListInspect");
//        }

//        public bool IsUserLoggedIn()
//        {
//            return IsLogin;
//        }
//        public void SetUserLoggedIn()
//        {
//            IsLogin = true;
//        }
//    }
//}
