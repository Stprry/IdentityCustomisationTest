﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly IdentityCustomisationTest.Data.ApplicationDbContext _context;

        public DetailsModel(IdentityCustomisationTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Property Property { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Property = await _context.Property.FirstOrDefaultAsync(m => m.ID == id);

            if (Property == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
