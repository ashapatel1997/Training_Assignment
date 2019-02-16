using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard
{
    public class DbPostDataContext:DbContext
    {
        public DbSet<PostMessage> postMessage { get; set; }
        public DbPostDataContext(DbContextOptions<DbPostDataContext> options)
           : base(options)
        {
        }
       
    }
}
