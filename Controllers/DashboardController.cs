using System;
using Coffee_POS.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Coffee_POS.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.TotalProducts = await _context.Products.CountAsync();
            ViewBag.TotalOrders = await _context.Orders.CountAsync();
            ViewBag.TotalAssets = await _context.Assets.CountAsync();
            ViewBag.TotalPurchase = await _context.Purchases.CountAsync();

            ViewBag.RecentOrders = await _context.Orders
                .Include(o => o.User)
                .OrderByDescending(o => o.Id)
                .Take(5)
                .ToListAsync();

            return View();
        }

    }
}
