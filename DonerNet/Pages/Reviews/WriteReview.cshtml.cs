using DonerNet.Data;
using DonerNet.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace DonerNet.Pages.Reviews
{
    public class WriteReviewModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public WriteReviewModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Review Review { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _dbContext.Reviews.Add(Review);
            _dbContext.SaveChanges();

            return RedirectToPage("/Reviews/Reviews");
        }
    }
}
