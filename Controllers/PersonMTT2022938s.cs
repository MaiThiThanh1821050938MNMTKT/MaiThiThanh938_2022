using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MaiThiThanh2022938.Models;
using MaiThiThanh2022938.Data;

namespace MaiThiThanh2022938.Controllers
{
    public class PersonMTT2022938sController : Controller
    {
        private readonly ApplicationContext _context;

        public PersonMTT2022938sController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: PersonMTT2022938s
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonMTT2022938.ToListAsync());
        }

        // GET: PersonMTT2022938s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var PersonMTT2022938 = await _context.PersonMTT2022938
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (PersonMTT2022938 == null)
            {
                return NotFound();
            }

            return View(PersonMTT2022938);
        }

        // GET: PersonMTT2022938s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonMTT2022938s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonMTT2022938 PersonMTT2022938)
        {
            if (ModelState.IsValid)
            {
                _context.Add(PersonMTT2022938);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(PersonMTT2022938);
        }

        // GET: PersonMTT2022938s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var PersonMTT2022938 = await _context.PersonMTT2022938.FindAsync(id);
            if (PersonMTT2022938 == null)
            {
                return NotFound();
            }
            return View(PersonMTT2022938);
        }

        // POST: PersonMTT2022938s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] PersonMTT2022938 PersonMTT2022938)
        {
            if (id != PersonMTT2022938.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(PersonMTT2022938);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonMTT2022938Exists(PersonMTT2022938.PersonId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(PersonMTT2022938);
        }

        // GET: PersonMTT2022938s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var PersonMTT2022938 = await _context.PersonMTT2022938
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (PersonMTT2022938 == null)
            {
                return NotFound();
            }

            return View(PersonMTT2022938);
        }

        // POST: PersonMTT2022938s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var PersonMTT2022938 = await _context.PersonMTT2022938.FindAsync(id);
            _context.PersonMTT2022938.Remove(PersonMTT2022938);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonMTT2022938Exists(string id)
        {
            return _context.PersonMTT2022938.Any(e => e.PersonId == id);
        }
    }
}
