using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IdentityCustomisationTest.Data;
using IdentityCustomisationTest.Models;

namespace IdentityCustomisationTest.Pages.Properties
{
    public class CreateModel : PageModel
    {
        private readonly IdentityCustomisationTest.Data.ApplicationDbContext _context;

        public CreateModel(IdentityCustomisationTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Property Property { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Property.Add(Property);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}