using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using eman.Models;

namespace eman.Controllers;

public class EmanController : Controller
{
    public IActionResult Index(){
        return View();
    }
}




