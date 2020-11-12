using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SocialMedia.Models
{
    public class Reply
    { 
        [Key]
        public int  Id { get; set; }
        [Required]
        public string ReplyComment { get; set; }
    }
}