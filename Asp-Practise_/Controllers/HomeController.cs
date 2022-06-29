using Asp_Practise_.DAL;
using Asp_Practise_.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise_.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Sliders = _context.Sliders.ToList();
            homeVM.SliderContents = _context.SliderContents.FirstOrDefault();
            homeVM.NoticeLeftSides = _context.Notices.ToList();
            homeVM.NoticeRightSides = _context.NoticeRights.ToList();
            homeVM.Courses = _context.Course.ToList();
            homeVM.Blogs = _context.Blogs.ToList();
            homeVM.Event = _context.Event.ToList();
           
            return View(homeVM);
        }
        
    }
}
