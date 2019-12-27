using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BloodBankApplication.Models;
using BloodBankApplication.Data;
using Microsoft.EntityFrameworkCore;

namespace BloodBankApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public async Task<IActionResult> Display(string searchString, string searchstring2)
        {
            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentFilter1"] = searchstring2;
            

            var students = from s in _context.Donors
                           select s;

            if (!String.IsNullOrEmpty(searchString) && !String.IsNullOrEmpty(searchstring2))
            {
                students = students.Where(s => s.bloodGroup.Contains(searchString) && s.city.Contains(searchstring2));
            }

            //return View(await _context.Donors.ToListAsync());
            return View(await students.AsNoTracking().ToListAsync());
        }


        public IActionResult Privacy()
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
