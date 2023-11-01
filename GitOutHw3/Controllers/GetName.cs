using Microsoft.AspNetCore.Mvc;

namespace GitOutHw3.Controllers
{
    public class GetName : Controller
    {
        public IActionResult GetMyName()
        {
            var myName = new { Name = "Your Name" };
            return Json(myName);
        }
    }
}
