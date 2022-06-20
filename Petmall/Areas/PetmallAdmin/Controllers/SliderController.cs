using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petmall.DAL;
using Petmall.Extensions;
using Petmall.Models;
using Petmall.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petmall.Areas.PetmallAdmin.Controllers
{
    [Area("PetmallAdmin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> slider = await _context.Sliders.ToListAsync();
            return View(slider);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();
            if (slider.Photo != null)
            {
                if (slider.Photo.IsOkay(1))
                {
                    ModelState.AddModelError("Photo", "Please,choose image file which size under 1 mb");
                    return View();
                }
                slider.Image = await slider.Photo.FileCreate(_env.WebRootPath, @"assets\image");
                await _context.AddAsync(slider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("Photo", "Please, choose image file");
                return View();
            }
            
        }
        public async Task<IActionResult> Detail(int id)
        {
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s=>s.Id==id);
            return View(slider);
        }
        public async Task<IActionResult> Edit(int id)
        {
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(int id,Slider slider)
        {
            if (!ModelState.IsValid) return View(slider);
            Slider existedSlider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider.Photo != null)
            {
                if (!slider.Photo.IsOkay(1))
                {
                    string path = _env.WebRootPath + @"assets\image" + existedSlider.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    existedSlider.Image = await slider.Photo.FileCreate(_env.WebRootPath, @"assets\image");
                }
                else
                {
                    ModelState.AddModelError("Photo", "Selected image is not valid!");
                    return View(slider);
                }
            }
            existedSlider.Title = slider.Title;
            existedSlider.Subtitle = slider.Subtitle;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();

            return View(slider);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSlider(int id)
        {
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
