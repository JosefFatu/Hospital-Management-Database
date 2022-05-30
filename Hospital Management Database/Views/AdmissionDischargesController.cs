using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hospital_Management_Database.Data;
using Hospital_Management_Database.Models;

namespace Hospital_Management_Database.Views
{
    public class AdmissionDischargesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdmissionDischargesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AdmissionDischarges
        public async Task<IActionResult> Index()
        {
            return View(await _context.AdmissionDischarge.ToListAsync());
        }

        // GET: AdmissionDischarges/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admissionDischarge = await _context.AdmissionDischarge
                .FirstOrDefaultAsync(m => m.AdmissionDischargeId == id);
            if (admissionDischarge == null)
            {
                return NotFound();
            }

            return View(admissionDischarge);
        }

        // GET: AdmissionDischarges/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AdmissionDischarges/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdmissionDischargeId,wardnumber,bednumber,dateadmitted,datedischarged")] AdmissionDischarge admissionDischarge)
        {
            if (ModelState.IsValid)
            {
                _context.Add(admissionDischarge);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(admissionDischarge);
        }

        // GET: AdmissionDischarges/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admissionDischarge = await _context.AdmissionDischarge.FindAsync(id);
            if (admissionDischarge == null)
            {
                return NotFound();
            }
            return View(admissionDischarge);
        }

        // POST: AdmissionDischarges/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdmissionDischargeId,wardnumber,bednumber,dateadmitted,datedischarged")] AdmissionDischarge admissionDischarge)
        {
            if (id != admissionDischarge.AdmissionDischargeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admissionDischarge);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdmissionDischargeExists(admissionDischarge.AdmissionDischargeId))
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
            return View(admissionDischarge);
        }

        // GET: AdmissionDischarges/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admissionDischarge = await _context.AdmissionDischarge
                .FirstOrDefaultAsync(m => m.AdmissionDischargeId == id);
            if (admissionDischarge == null)
            {
                return NotFound();
            }

            return View(admissionDischarge);
        }

        // POST: AdmissionDischarges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admissionDischarge = await _context.AdmissionDischarge.FindAsync(id);
            _context.AdmissionDischarge.Remove(admissionDischarge);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdmissionDischargeExists(int id)
        {
            return _context.AdmissionDischarge.Any(e => e.AdmissionDischargeId == id);
        }
    }
}
