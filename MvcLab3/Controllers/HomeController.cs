using Microsoft.AspNetCore.Mvc;
using MvcLab3.Models;
using System.Diagnostics;

namespace MvcLab3.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration configuration;


    public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
    {
      _logger = logger;
      this.configuration = configuration;
    }

    public IActionResult Index()
    {
      ViewBag.Mode = this.configuration.GetSection("Mode").Value;
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}