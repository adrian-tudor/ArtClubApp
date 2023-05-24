using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArtClubApp.Controllers
{
    public class LandingPageController : Controller
    {
        // GET: LandingPageController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LandingPageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LandingPageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LandingPageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LandingPageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LandingPageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LandingPageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LandingPageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
