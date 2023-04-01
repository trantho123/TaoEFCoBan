using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetRazorsPageEFCore.Models;
using WebApplication4.Data;

namespace WebApplication4.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication4.Data.WebApplication4Context _context;

        public IndexModel(WebApplication4.Data.WebApplication4Context context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
