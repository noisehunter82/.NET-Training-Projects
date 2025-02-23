using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EfcSqlWebApp.Data;
using EfcSqlWebApp.Models;

namespace EfcSqlWebApp.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly EfcSqlWebApp.Data.MyPracticeDbContext _context;

        public IndexModel(EfcSqlWebApp.Data.MyPracticeDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
