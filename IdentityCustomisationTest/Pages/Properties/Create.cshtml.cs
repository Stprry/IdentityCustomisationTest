using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IdentityCustomisationTest.Data;
using IdentityCustomisationTest.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

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

            var path = Path.Combine(
            Directory.GetCurrentDirectory(), "wwwroot/uploads",
            Property.MainImage.FileName);
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await Property.MainImage.CopyToAsync(stream);
                Property.MainImagePath = Property.MainImage.FileName;
            }

            _context.Property.Add(Property);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}