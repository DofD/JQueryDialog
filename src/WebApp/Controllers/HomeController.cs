using System.Linq;
using System.Web.Mvc;
using WebApp.Entities;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private DataBase db = new DataBase();

        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }

        // GET: /User/Details/5
        public ActionResult Details(int id = 0)
        {
            var user = db.Users.FirstOrDefault(u => u.UserID == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: /User/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: /User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserViewModel user, string Command)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);

                TempData["Msg"] = "Data has been saved succeessfully";
                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: /User/Edit/5
        public ActionResult Edit(int id = 0)
        {
            var user = db.Users.FirstOrDefault(u => u.UserID == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: /User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                db.Users.RemoveAll(u => u.UserID == user.UserID);
                db.Users.Add(user);
                TempData["Msg"] = "Data has been updated succeessfully";
                return RedirectToAction("Index");
            }
            return View(user);
        }

        // GET: /User/Delete/5
        public ActionResult Delete(int id)
        {
            var user = db.Users.FirstOrDefault(u => u.UserID == id);
            db.Users.RemoveAll(u => u.UserID == user.UserID);
            TempData["Msg"] = "Data has been deleted succeessfully";
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
