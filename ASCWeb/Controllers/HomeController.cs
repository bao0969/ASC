using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASCWeb.Models;
using ASCWeb.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ASC.Utilities;
namespace ASCWeb.Controllers;

public class HomeController : Controller
{

    private IOptions<ApplicationSettings> _settings;

    public HomeController( IOptions<ApplicationSettings> settings)
    {
        _settings = settings;
    }

    public IActionResult Index()
    {
        //// Set Session
        HttpContext.Session.SetSession("Test", _settings.Value);

        //// Get Session
        var settings = HttpContext.Session.GetSession<ApplicationSettings>("Test");

        //// Usage of IOptions
        ViewBag.Title = _settings.Value.ApplicationTitle;

        //// Test fail test case
        // ViewData.Model = "Test";
        // throw new Exception("Login Fail!!!");

        return View();
    }


    public IActionResult Privacy()
    {
        {
            ViewData.Model = "Test";
        }
        throw new Exception("Login Fail!!!");
            return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult Dashboard()
    {
        return View();
    }


}
