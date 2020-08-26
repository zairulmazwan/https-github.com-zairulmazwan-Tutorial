﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tutorial.Data;
using Tutorial.Models;

namespace Tutorial.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Tutorial.Data.TutorialContext _context;

        public IndexModel(Tutorial.Data.TutorialContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
