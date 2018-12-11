using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IdentityCustomisationTest.Data;
using IdentityCustomisationTest.Models;

namespace IdentityCustomisationTest.Pages.Properties
{
    public class IndexModel : PageModel
    {
        private readonly IdentityCustomisationTest.Data.ApplicationDbContext _context;

        public IndexModel(IdentityCustomisationTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Property> Property { get;set; }

        public async Task OnGetAsync()
        {
            Property = await _context.Property.ToListAsync();
        }
    }
}
