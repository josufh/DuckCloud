using Microsoft.AspNetCore.Mvc;

namespace DuckCloud.Server.Controllers;

public class MemcardController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return Content("Hello world!");
    }

    [HttpGet]
    public IActionResult Saves()
    {
        return Content("Save list.");
    }
}