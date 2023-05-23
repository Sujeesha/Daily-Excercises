using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployApplication.Data;
using EmployApplication.Model;

namespace EmployApplication.Pages.Employee
{
    public class EditModel : PageModel
    {
        private readonly EmployApplication.Data.EmployApplicationContext _context;

        public EditModel(EmployApplication.Data.EmployApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Emp Emp { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Emp == null)
            {
                return NotFound();
            }

            var emp =  await _context.Emp.FirstOrDefaultAsync(m => m.Id == id);
            if (emp == null)
            {
                return NotFound();
            }
            Emp = emp;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Emp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpExists(Emp.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmpExists(int id)
        {
          return (_context.Emp?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
