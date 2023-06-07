using DonerNet.Data;
using DonerNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DonerNet.Pages
{
    public class OrdersModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<DonerOrder> DonerOrders { get; set; }

        public void OnGet()
        {
            DonerOrders = _context.DonerOrders.OrderByDescending(o => o.Id).ToList();
        }

        public IActionResult OnPostDelete(int id)
        {
            var order = _context.DonerOrders.Find(id);

            if (order == null)
            {
                return NotFound();
            }

            _context.DonerOrders.Remove(order);
            _context.SaveChanges();

            return RedirectToPage("/Orders");
        }
    }
}
