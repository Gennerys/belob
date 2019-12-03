using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using HotelBooking.Models;
using HotelBooking.ModelBuilders.Abstract;
using HotelBooking.ViewModels;
using System.IO;
using Microsoft.AspNetCore.Hosting;


namespace HotelBooking.Controllers {
    public class HomeController : Controller {

        private readonly IProfileModelBuilder profileModelBuilder;
        private readonly IFormBuilder formBuilder;
        private readonly IHostingEnvironment _appEnvironment;
		

        public HomeController(WdaContext wdaContext, SignInManager<User> signInManager, IProfileModelBuilder profileModelBuilder, IFormBuilder formBuilder) {
            this.profileModelBuilder = profileModelBuilder;
            this.formBuilder = formBuilder;			
     
        }

        public IActionResult Index() {
            ViewData["Cities"] = formBuilder.GetCities();
            ViewData["RoomTypes"] = formBuilder.GetRoomTypes();
            return View();
        }

        [Route("Home/Profile")]
        public IActionResult Profile() {
            var profileViewModel = profileModelBuilder.BuildModel(HttpContext.User);
            return View(profileViewModel);
        }


        [HttpPost]
        public IActionResult Index(RoomSearchModel roomSearchModel) {
            if (!ModelState.IsValid) {
                ViewData["Cities"] = formBuilder.GetCities();
                ViewData["RoomTypes"] = formBuilder.GetRoomTypes();
                return View(roomSearchModel);
            }
            return RedirectToAction("SearchResults", "Search", roomSearchModel);
        }

        public IActionResult GetHelp()
        {
            return View();
        }
		public IActionResult Admin()
		{
			return View();
		}


	}
    //// Путь к файлу
    //string file_path = Path.Combine(_appEnvironment.ContentRootPath, "wwwroot/lib/ytyt/Функциональные_требования_Папирнык.pdf");
    //// Тип файла - content-type
    //string file_type = "application/pdf";
    //// Имя файла - необязательно
    //string file_name = "Функциональные_требования_Папирнык.pdf";
    //return PhysicalFile(file_path, file_type, file_name);
    //var filepath = Path.Combine("~/lib/ytyt/Функциональные_требования_Папирнык.pdf", "hello.txt");
    //return File(filepath, "text/plain", "hello.txt");
}