using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using KarvanPlan.Models;

namespace KarvanPlan.Pages.PlanReports
{
    public class PlanModel : PageModel
    {
        private readonly DbContexts _context;

        public PlanModel(DbContexts context)
        {
            _context = context;
        }

        [BindProperty]
        public int Ay { get; set; }

        public List<PlanEntities> DataList { get; set; } // Verileri tutacak model

        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var ayParameter = new SqlParameter("@ay", Ay);
            var result = await _context.Database.ExecuteSqlRawAsync("EXEC IB_Plans @ay", ayParameter);

          
            ViewData["Message"] = "Prosedür başarıyla çalıştı.";

            
            DataList = await _context.PlanEntities.ToListAsync(); 

            return Page();
        }
    }
}
