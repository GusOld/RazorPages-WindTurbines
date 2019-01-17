using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesComments.Models
{
    public class Comment
    { 
        public int ID { get; set; }

        [MinLength(1), Required]
        public string Name { get; set; }

        [Display(Name = "Comment Date")]
        public DateTime CommentDate { get; set; } = DateTime.Now;

        [Display(Name = "Comment"), Required]       
        public string CommentContent { get; set; }
    }

}
