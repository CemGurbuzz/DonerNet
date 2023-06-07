using DonerNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DonerNet.Pages.Forms
{
    public class CustomMenuModel : PageModel
    {
        [BindProperty]
        public DonersModel Doner{ get; set; }
        public float DonerPrice{ get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            DonerPrice = Doner.BasePrice;

            if (Doner.Beef) DonerPrice += 4;
            else DonerPrice += 3;

            DonerPrice *= Doner.Quantity;

            if (Doner.Durum) DonerPrice += 0;
            if (Doner.Tombik) DonerPrice += 0;
            if (Doner.Portion) DonerPrice += 0;

            if (Doner.Sauce) DonerPrice += 0.5f;
            if (Doner.Onion) DonerPrice += 0.5f;
            if (Doner.Tomato) DonerPrice += 0.5f;
            if (Doner.Pickle) DonerPrice += 0.5f;
            if (Doner.Tahin) DonerPrice += 0.5f;
            if (Doner.Yogurt) DonerPrice += 0.5f;
            if (Doner.PotatoFries) DonerPrice += 2;
            if (Doner.OnionRing) DonerPrice += 2;
            if (Doner.Cola) DonerPrice += 1;
            if (Doner.Ayran) DonerPrice += 1;
            if (Doner.Soda) DonerPrice += 1;
            if (Doner.Water) DonerPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new { Doner.DonerName, DonerPrice });
        }
    }
}
