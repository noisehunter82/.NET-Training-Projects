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
    public class IndexModel : PageModel
    {
        private readonly EfcSqlWebApp.Data.MyPracticeDbContext _context;

        public IndexModel(EfcSqlWebApp.Data.MyPracticeDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
