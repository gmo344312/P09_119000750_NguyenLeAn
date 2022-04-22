#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NguyenLeAn.Models;

namespace NguyenLeAn.Pages_Comment
{
    public class IndexModel : PageModel
    {
        private readonly NewsContext _context;

        public IndexModel(NEwsContext context)
        {
            _context = context;
        }

        public IList<comment> comment { get;set; }

        public async Task OnGetAsync()
        {
            comment = await _context.Comment.ToListAsync();
        }
    }
}
