using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class Blog : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var result=_blogManager.GetList();
            return View(result);
        }
    }
}
