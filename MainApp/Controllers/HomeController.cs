using Microsoft.AspNetCore.Mvc;

namespace MainApp.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        int hour = DateTime.Now.Hour;
        string viewModel = hour > 12 ? "Good afternoon" : "Good Morning";
        return View("MyView", viewModel);
    }

}
