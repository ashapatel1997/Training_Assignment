using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard_WebAPI.Models
{
    public class PostMessage
    {
        public int Id { get; set; }
        [Required]
        public string Message { get; set; }

        public int Total_Likes { get; set; }

        public List<CommentMessage> Comment { get; set; }

    }
}
