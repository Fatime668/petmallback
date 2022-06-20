using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petmall.DAL;
using Petmall.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petmall.Areas.PetmallAdmin.Controllers
{
    [Area("PetmallAdmin")]
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;

        public SettingController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM { 
            Settings = await _context.Settings.ToListAsync(),
            Icons = await _context.Icons.ToListAsync()
            };

            return View(homeVM);
        }
    }
}
