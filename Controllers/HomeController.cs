using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller {

        //localhost/home/index 
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour; 

            ViewBag.selamlama = saat > 12? "İyi Günler":"Günaydın";
            ViewBag.Username = "Ugurcan";

            var meetingInfo= new MeetingInfo(){
                Id=1,
                Location="Istanbul",
                Date= new DateTime(2024,01,20,20,0,0),
                NumberOfPeople=100
            };


            return View(meetingInfo);
        }
    }
}