using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeryContext _db;
    public HomeController(BakeryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Flavor> FlavorList = _db.Flavors.ToList();
      List<Treat> TreatList = _db.Treats.ToList();
      ViewBag.Flavors = FlavorList;
      ViewBag.Treats = TreatList;
      return View();
    }
  }
}