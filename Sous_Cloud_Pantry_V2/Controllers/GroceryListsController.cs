﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sous_Cloud_Pantry_V2.models;

namespace Sous_Cloud_Pantry_V2.Controllers
{
    [Authorize]
    public class GroceryListsController : Controller
    {
        private readonly SousKitchenPantryDBContext _context;

        public GroceryListsController(SousKitchenPantryDBContext context)
        {
            _context = context;
        }

        // GET: GroceryLists
        public async Task<IActionResult> Index()
        {
            var currentUser = from u in _context.GroceryLists
                              where u.UserName == User.Identity.Name
                              select u;

            return View(await currentUser.ToListAsync());
            //return View(await _context.GroceryLists.ToListAsync());
        }

        // GET: GroceryLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groceryList = await _context.GroceryLists
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (groceryList == null)
            {
                return NotFound();
            }

            return View(groceryList);
        }

        // GET: GroceryLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GroceryLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,ListItem,UserName")] GroceryList groceryList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(groceryList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(groceryList);
        }

        // GET: GroceryLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groceryList = await _context.GroceryLists.FindAsync(id);
            if (groceryList == null)
            {
                return NotFound();
            }
            return View(groceryList);
        }

        // POST: GroceryLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,ListItem,UserName")] GroceryList groceryList)
        {
            if (id != groceryList.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(groceryList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroceryListExists(groceryList.UserId))
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
            return View(groceryList);
        }

        // GET: GroceryLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groceryList = await _context.GroceryLists
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (groceryList == null)
            {
                return NotFound();
            }

            return View(groceryList);
        }

        // POST: GroceryLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var groceryList = await _context.GroceryLists.FindAsync(id);
            _context.GroceryLists.Remove(groceryList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroceryListExists(int id)
        {
            return _context.GroceryLists.Any(e => e.UserId == id);
        }
    }
}
