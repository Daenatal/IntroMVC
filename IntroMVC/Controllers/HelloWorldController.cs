using IntroMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<CatViewModel> cats = new List<CatViewModel>();
        public IActionResult Index()
        {
            return View(cats);
        }

        public IActionResult Create()
        {
            var catVm = new CatViewModel();
            return View(catVm);
        }

        public IActionResult CreateCat(CatViewModel catViewModel)
        {
            //return View("Index");
            cats.Add(catViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Hello()
        {
            CatViewModel newcat = new CatViewModel()
            { Name = "Cheems", Age = 5 };
            return View(newcat);
        }
        public IActionResult HotelBooking()
        {
            HotelBookingModel newbooking = new HotelBookingModel()
            {
                GuestName = "Astro Man",
                Id = 11233,
                DateStart = DateTime.Parse("2022/04/08"),
                DateEnd = DateTime.Parse("2022/04/14")
            };
            return View(newbooking);
        }
    }
}
