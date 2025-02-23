using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EfcSqlWebApp.Data;
using EfcSqlWebApp.Models;

namespace EfcSqlWebApp.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly EfcSqlWebApp.Data.MyPracticeDbContext _context;

        public DetailsModel(EfcSqlWebApp.Data.MyPracticeDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
            }
            return Page();
        }
    }
}
