using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployApplication.Data;
using EmployApplication.Model;

namespace EmployApplication.Pages.Employee
{
    public class IndexModel : PageModel
    {
        private readonly EmployApplication.Data.EmployApplicationContext _context;

        public IndexModel(EmployApplication.Data.EmployApplicationContext context)
        {
            _context = context;
        }

        public IList<Emp> Emp { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Emp != null)
            {
                Emp = await _context.Emp.ToListAsync();
            }
        }
    }
}
