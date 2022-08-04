using Microsoft.AspNetCore.Mvc;
using UdemyCourseFirstMVCApp.Models;

namespace UdemyCourseFirstMVCApp.Controllers
{
    public class HellowWorldController : Controller
    {

        private static List<DogViewmodel> dog = new List<DogViewmodel>();
        private static List<HotelBooking> hotel = new List<HotelBooking>();

        public IActionResult Index()
        {
            
            return View(dog);
        }

        public IActionResult Create()
        {
            var dogVM = new DogViewmodel();
            return View(dogVM);
        }

        public IActionResult CreateDog(DogViewmodel dogViewModel)
        {
            // return View("Index");
            dog.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        
        public IActionResult Hello()
        {
            return View();
        }

        public IActionResult Hotel()
        {
            return View(hotel);
        }
        
        public IActionResult HotelBooking()
        {
            var hotelVM = new HotelBooking();
            return View(hotelVM);
        }

        public IActionResult CreateHotel(HotelBooking hotelviewBooking)
        {
           hotel.Add(hotelviewBooking);
            return RedirectToAction(nameof(Hotel));
        }
        


        
    }
}
