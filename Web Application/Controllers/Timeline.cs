using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Application.Controllers
{
    public class Timeline : Controller
    {
        // GET: Timeline
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult TimelineView()
        {
            return View();
        }

        // GET: Timeline/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Timeline/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Timeline/Create
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

        // GET: Timeline/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Timeline/Edit/5
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

        // GET: Timeline/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Timeline/Delete/5
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
