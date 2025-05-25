using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour; 

            ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.UsurName = "Tolgahan";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, ABC Kongre Merkezi",
                Date = new DateTime(2025, 05, 25, 20, 0, 0),
                NumberOfPeople = 100
            };

            return View(meetingInfo);
        }
    }
}