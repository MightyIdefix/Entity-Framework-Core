using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restuarant.Models;

namespace Restaurant.Controllers
{
    public class RestaurantClassesController : Controller
    {
        private readonly AppDbContext _context;

        public RestaurantClassesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: RestaurantClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Restaurants.ToListAsync());
        }

        // GET: RestaurantClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurantClass = await _context.Restaurants
                .FirstOrDefaultAsync(m => m.RestaurantId == id);
            if (restaurantClass == null)
            {
                return NotFound();
            }

            return View(restaurantClass);
        }

        // GET: RestaurantClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RestaurantClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RestaurantId,Name,Address,AverageRating,Type")] RestaurantClass restaurantClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(restaurantClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(restaurantClass);
        }

        // GET: RestaurantClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurantClass = await _context.Restaurants.FindAsync(id);
            if (restaurantClass == null)
            {
                return NotFound();
            }
            return View(restaurantClass);
        }

        // POST: RestaurantClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RestaurantId,Name,Address,AverageRating,Type")] RestaurantClass restaurantClass)
        {
            if (id != restaurantClass.RestaurantId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restaurantClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestaurantClassExists(restaurantClass.RestaurantId))
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
            return View(restaurantClass);
        }

        // GET: RestaurantClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurantClass = await _context.Restaurants
                .FirstOrDefaultAsync(m => m.RestaurantId == id);
            if (restaurantClass == null)
            {
                return NotFound();
            }

            return View(restaurantClass);
        }

        // POST: RestaurantClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restaurantClass = await _context.Restaurants.FindAsync(id);
            _context.Restaurants.Remove(restaurantClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestaurantClassExists(int id)
        {
            return _context.Restaurants.Any(e => e.RestaurantId == id);
        }
    }
}
