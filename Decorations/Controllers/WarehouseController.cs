using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Decorations.Data;
using Microsoft.Extensions.Localization;

namespace Decorations.Controllers
{
    public class WarehouseController : BaseController<WarehouseController>
    {
        private readonly AppDbContext _context;

        public WarehouseController(AppDbContext context, IStringLocalizer<WarehouseController> localizer)
            : base(localizer)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var warehouses = await _context.Warehouses.Include(w => w.Shop).ToListAsync();
            SetViewData();
            return View(warehouses);
        }
    }
}