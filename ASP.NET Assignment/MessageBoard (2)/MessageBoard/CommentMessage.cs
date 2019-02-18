using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard
{
    public class CommentMessage
    {
        public int Id { get; set; }
        [Required]
        public string Comment { get; set; }
        
    }
}
