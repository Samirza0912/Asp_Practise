using Asp_Practise_.DAL;
using Asp_Practise_.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise_.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            EventVm eventVm = new EventVm();
            eventVm.Event = _context.Event.ToList();
            return View(eventVm);
        }
    }
}
