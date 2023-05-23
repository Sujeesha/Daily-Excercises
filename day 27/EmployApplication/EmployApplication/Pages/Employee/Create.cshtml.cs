using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EmployApplication.Data;
using EmployApplication.Model;

namespace EmployApplication.Pages.Employee
{
    public class CreateModel : PageModel
    {
        private readonly EmployApplication.Data.EmployApplicationContext _context;

        public CreateModel(EmployApplication.Data.EmployApplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Emp Emp { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Emp == null || Emp == null)
            {
                return Page();
            }

            _context.Emp.Add(Emp);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
