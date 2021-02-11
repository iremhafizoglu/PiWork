using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PiWorks.Models;

namespace PiWorks.Controllers
{
    public class HomeController : Controller
    {
        private static List<User> _userList = new List<User>();

        public IActionResult Index()
        {
            return View(_userList);
        }
        public IActionResult Form(int? id)
        {
            if (id.HasValue == true)
            {
                var user = _userList.Single(x => x.Id == id.Value);
                return View(user);
            }
            else
            {
                return View(new User());
            }
        }
        public IActionResult Save(User user)
        {
            _userList.Add(user);
            return RedirectToAction("Index");
        }

    }
}
