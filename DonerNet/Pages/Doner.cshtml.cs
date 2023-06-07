using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DonerNet.Models;

namespace DonerNet.Pages
{
    public class DonerModel : PageModel
    {
        public List<DonersModel> fakeDonerDB = new List<DonersModel>()
        {
            new DonersModel(){ImageTitle="et-porsiyon", DonerName="Beef Portion", BasePrice=5, Sauce=true, PotatoFries=true, Cola=true, FinalPrice=7},
            new DonersModel(){ImageTitle="tavuk-porsiyon", DonerName="Chicken Portion", BasePrice=4, Sauce=true, PotatoFries=true, Cola=true, FinalPrice=6},
            new DonersModel(){ImageTitle="et-durum-menu", DonerName="Beef Dürüm Menu", BasePrice=4, Sauce=true, PotatoFries=true, Cola=true, FinalPrice=7},
            new DonersModel(){ImageTitle="tavuk-durum-menu", DonerName="Chicken Dürüm Menu", BasePrice=4, Sauce=true, PotatoFries=true, Cola=true, FinalPrice=6},
            new DonersModel(){ImageTitle="et-tombik-menu", DonerName="Beef Tombik Menu", BasePrice=4, Sauce=true, PotatoFries=true, Cola=true, FinalPrice=7},
            new DonersModel(){ImageTitle="tavuk-tombik-menu", DonerName="Chicken Tombik Menu", BasePrice=4, Sauce=true, PotatoFries=true, Cola=true, FinalPrice=6},
            new DonersModel(){ImageTitle="et-durum", DonerName="Beef Dürüm", BasePrice=4, FinalPrice=4},
            new DonersModel(){ImageTitle="tavuk-durum", DonerName="Chicken Dürüm", BasePrice=3, FinalPrice=3},
            new DonersModel(){ImageTitle="et-tombik", DonerName="Beef Tombik", BasePrice=4, FinalPrice=4},
            new DonersModel(){ImageTitle="tavuk-tombik", DonerName="Chicken Tombik", BasePrice=3, FinalPrice=3},

        };
        public void OnGet()
        {
        }
    }
}
