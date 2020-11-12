using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SocialMedia.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage ="This is too short of a title!")]

        public string Title { get; set; }
        [Required]
        public string Text { get; set; }

    }
}