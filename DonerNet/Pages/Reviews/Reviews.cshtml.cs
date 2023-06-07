using DonerNet.Data;
using DonerNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonerNet.Pages
{
    public class ReviewsModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public ReviewsModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Review> Reviews { get; set; }

        public async Task OnGetAsync()
        {
            Reviews = await _dbContext.Reviews.OrderByDescending(r => r.Id).ToListAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int reviewId)
        {
            var review = await _dbContext.Reviews.FindAsync(reviewId);

            if (review == null)
            {
                return NotFound();
            }

            _dbContext.Reviews.Remove(review);
            await _dbContext.SaveChangesAsync();

            return RedirectToPage("/Reviews/Reviews");
        }
    }
}
