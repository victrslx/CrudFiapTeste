using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudFiapTeste.Data;
using CrudFiapTeste.Models;

namespace CrudFiapTeste.Controllers
{
    public class UserPromotionRegistersController : Controller
    {
        private readonly CrudFiapTesteContext _context;

        public UserPromotionRegistersController(CrudFiapTesteContext context)
        {
            _context = context;
        }

        // GET: UserPromotionRegisters
        public async Task<IActionResult> ListUser()
        {
            return View(await _context.UserPromotionRegister.ToListAsync());
        }

        // GET: UserPromotionRegisters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPromotionRegister = await _context.UserPromotionRegister
                .FirstOrDefaultAsync(m => m.id == id);
            if (userPromotionRegister == null)
            {
                return NotFound();
            }

            return View(userPromotionRegister);
        }

        // GET: UserPromotionRegisters/Index
        public IActionResult Index()
        {
            return View();
        }

        // POST: UserPromotionRegisters/Index
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("id,name,email,number")] UserPromotionRegister userPromotionRegister)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userPromotionRegister);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListUser));
            }
            return View(userPromotionRegister);
        }

        // GET: UserPromotionRegisters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPromotionRegister = await _context.UserPromotionRegister.FindAsync(id);
            if (userPromotionRegister == null)
            {
                return NotFound();
            }
            return View(userPromotionRegister);
        }

        // POST: UserPromotionRegisters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,email,number")] UserPromotionRegister userPromotionRegister)
        {
            if (id != userPromotionRegister.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userPromotionRegister);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserPromotionRegisterExists(userPromotionRegister.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListUser));
            }
            return View(userPromotionRegister);
        }

        // GET: UserPromotionRegisters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userPromotionRegister = await _context.UserPromotionRegister
                .FirstOrDefaultAsync(m => m.id == id);
            if (userPromotionRegister == null)
            {
                return NotFound();
            }

            return View(userPromotionRegister);
        }

        // POST: UserPromotionRegisters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userPromotionRegister = await _context.UserPromotionRegister.FindAsync(id);
            _context.UserPromotionRegister.Remove(userPromotionRegister);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListUser));
        }

        private bool UserPromotionRegisterExists(int id)
        {
            return _context.UserPromotionRegister.Any(e => e.id == id);
        }
    }
}
