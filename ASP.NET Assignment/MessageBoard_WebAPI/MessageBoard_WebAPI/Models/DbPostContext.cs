using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard_WebAPI.Models
{
    public class DbPostContext:DbContext
    {
        public DbPostContext(DbContextOptions<DbPostContext> options):base(options)
        {

        }
       public DbSet<PostMessage> postMessageData { get; set; }
        
    }
}
