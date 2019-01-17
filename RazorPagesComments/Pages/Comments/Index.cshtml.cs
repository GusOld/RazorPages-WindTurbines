using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesComments.Models;

namespace RazorPagesComments.Pages.Comments
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesComments.Models.CommentContext _context;

        public IndexModel(RazorPagesComments.Models.CommentContext context)
        {
            _context = context;
        }

        public IList<Comment> Comment { get;set; }

        public async Task OnGetAsync()
        {
            Comment = await _context.Comment.ToListAsync();
        }
    }
}
