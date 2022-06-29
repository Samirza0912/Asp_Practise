using Asp_Practise_.DAL;
using Asp_Practise_.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise_.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            BlogVM blogVM = new BlogVM();
            blogVM.Blogs = _context.Blogs.ToList();
            return View(blogVM);
        }
    }
}
