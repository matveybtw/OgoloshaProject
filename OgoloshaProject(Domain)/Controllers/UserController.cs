using BL;
using DLL.Context;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OgoloshaProject_Domain_.Controllers
{
    public class UserController : Controller
    {
        private OgoloshaService ogoloshaService;
        public async Task<ActionResult> Index()
        {
            return View(await ogoloshaService.GetAllUsersAsync());
        }

        // GET: UserController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await ogoloshaService.GetUser(id));
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(User user)
        {
            try
            {
                await ogoloshaService.AddUser(user);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, User user)
        {
            try
            {
                ogoloshaService.UpdateUser(id, user);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            return View(await ogoloshaService.GetUser(id));
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, User user)
        {
            try
            {
                await ogoloshaService.RemoveUser(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
