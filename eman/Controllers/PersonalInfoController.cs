using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using eman.Models;

namespace eman.Controllers;

public class PersonalInfoController : Controller
{
    public IActionResult Index(){
        return View();
    }
}


