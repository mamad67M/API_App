using API_App.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_App.Controllers
{
    public class FriendController : Controller
    {

         private readonly List<Friend> friends = new List<Friend>() {
         new Friend(1, "Kindson",  "Munonye" , "Budapest", DateTime.Today),
         new Friend(2, "Oleander", "Yuba"    , "Nigeria",  DateTime.Today),
         new Friend(3, "Saffron",  "Lawrence", "Lagos",    DateTime.Today),
         new Friend(4, "Jadon",    "Munonye" , "Asaba",    DateTime.Today),
         new Friend(5, "Solace",   "Okeke"   , "Oko",      DateTime.Today)
        };
    
        // GET: FriendController
        public List<Friend> Index()
        {
            return friends;
        }

        //// GET: FriendController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: FriendController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FriendController/Create
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

        // GET: FriendController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FriendController/Edit/5
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

        // GET: FriendController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FriendController/Delete/5
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
