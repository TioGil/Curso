using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogCourse.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Display(Name="Blog")]
        public string Name { get; set; }

        //Navigation
        public virtual List<Post> Posts { get; set; }
    }
}