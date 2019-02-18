using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly DbPostDataContext db;

        public PostController(DbPostDataContext db)
        {
            this.db = db;
        }
        public IEnumerable<PostMessage> Get()
        {

            return db.postMessage.ToList();
            
        }
    }
    }