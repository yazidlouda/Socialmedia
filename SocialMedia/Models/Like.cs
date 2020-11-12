using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SocialMedia.Models
{
    public class Like
    {
        [Key]
        public bool LikedPost { get; set; }
        public Guid Liker { get; set; }
    }
}