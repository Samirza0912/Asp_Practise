using Asp_Practise_.DAL;
using Asp_Practise_.Models;
using Asp_Practise_.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise_.Controllers
{
    public class TeachersController : Controller
    {
        private readonly AppDbContext _context;
        public TeachersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            TeacherVM teacherVM = new TeacherVM();
            teacherVM.Teachers = _context.Teachers.ToList();
            return View(teacherVM);
        }
        public IActionResult SearchTeacher(string search)
        {
            List<Teachers> teachers = _context.Teachers
                .OrderBy(t => t.Id)
                .Where(t => t.Name
                .ToLower()
                .Contains(search.ToLower()))
                .Take(5)
                .ToList();
            return PartialView("_SearhPartialView", teachers);
        }
    }
}
