using eLaptops.Data;
using eLaptops.Data.Services;
using eLaptops.Models;
using Microsoft.AspNetCore.Mvc;

namespace eLaptops.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly IFeaturesService _service;
        public FeaturesController(IFeaturesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Features/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FeatureName,FeaturePictureURL,Description")]Features features)
        {
            if (!ModelState.IsValid)
            {
                return View(features);
            }
            await _service.AddAsync(features); 
            return RedirectToAction(nameof(Index));
        }


        //Get: Features/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var featuresDetails = await _service.GetByIdAsync(id);

            if (featuresDetails == null) return View("NotFound");
            return View(featuresDetails);
        }

        //Get: Features/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var featuresDetails = await _service.GetByIdAsync(id);
            if (featuresDetails == null) return View("NotFound");
            return View(featuresDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("FeatureID,FeatureName,FeaturePictureURL,Description")] Features features)
        {
            if (!ModelState.IsValid)
            {
                return View(features);
            }
            await _service.UpdateAsync(id, features);
            return RedirectToAction(nameof(Index));
        }

        //Get: Features/Edit/1
        public async Task<IActionResult> Delete(int id)
        {
            var featuresDetails = await _service.GetByIdAsync(id);
            if (featuresDetails == null) return View("NotFound");
            return View(featuresDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var featuresDetails = await _service.GetByIdAsync(id);
            if (featuresDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
