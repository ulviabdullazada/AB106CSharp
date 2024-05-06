using Microsoft.AspNetCore.Mvc;

namespace WebApplicationEmpty.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Salam(string name, string surname, int? id)
    {
        //ContentResult result = new ContentResult();
        //result.Content = "<p>Salam dostlar</p>";
        //result.ContentType = "text/html";

        //JsonResult result = new JsonResult(new
        //{
        //    Name = "Rauf"
        //});
        //ViewResult result = new ViewResult();
        if (id == 0)
        {
            return Content(name + " " + surname + " " +id);
        }
        else
        {
            return Json(new
            {
                name = "AzTU"
            });
        }
    }
}
