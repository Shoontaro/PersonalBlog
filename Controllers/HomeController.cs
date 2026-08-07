using Microsoft.AspNetCore.Mvc;
using PersonalBlog.Models;
using System.Diagnostics;
using PersonalBlog.Models;

namespace PersonalBlog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Post.Seeds());
        }

        public IActionResult Article(string id)
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
