using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroup.Data;
using RunGroup.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RunGroup.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClubController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Club> clubs = _context.Clubs.ToList();
            return View(clubs);
        }

        public IActionResult Detail(int id)
        {
            Club club = _context.Clubs.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
            return View(club);
        }
    }
}

