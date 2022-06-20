using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petmall.DAL;
using Petmall.Models;
using Petmall.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petmall.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            HomeVM homeVM = new HomeVM
            {
                Settings = await _context.Settings.ToListAsync(),
                Icons = await _context.Icons.ToListAsync()
            };
            return View(homeVM);

        }
    }
}
