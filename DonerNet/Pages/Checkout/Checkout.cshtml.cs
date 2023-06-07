using DonerNet.Data;
using DonerNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DonerNet.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {

        public string DonerName { get; set; }
        public float DonerPrice { get; set; }
        public string ImageTitle { get; set; }
        public DateTime OrderDateTime { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(DonerName))
            {
                DonerName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            OrderDateTime = DateTime.Now;

            DonerOrder donerOrder = new DonerOrder();
            donerOrder.DonerName = DonerName;
            donerOrder.BasePrice = DonerPrice;
            donerOrder.OrderDateTime = OrderDateTime;

            _context.DonerOrders.Add(donerOrder);
            _context.SaveChanges();

        }

    }
}
