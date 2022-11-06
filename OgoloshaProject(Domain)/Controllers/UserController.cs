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
        public async Task<ActionResult> Details(int id)
        {
            return View(await ogoloshaService.GetUser(id));
        }
        public ActionResult Create()
        {
            return View();
        }
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
        public ActionResult Edit(int id)
        {
            return View();
        }
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
        public async Task<ActionResult> Delete(int id)
        {
            return View(await ogoloshaService.GetUser(id));
        }
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
