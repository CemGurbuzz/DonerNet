using DonerNet.Data;
using DonerNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DonerNet.Pages.Reviews
{
    public class EditReviewModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public EditReviewModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Review Review { get; set; }

        public async Task<IActionResult> OnGetAsync(int reviewId)
        {
            Review = await _dbContext.Reviews.FindAsync(reviewId);

            if (Review == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _dbContext.Attach(Review).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewExists(Review.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/Reviews/Reviews");
        }

        private bool ReviewExists(int id)
        {
            return _dbContext.Reviews.Any(e => e.Id == id);
        }
    }
}
