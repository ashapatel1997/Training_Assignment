using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoard_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoard_WebAPI.Controllers
{
   
    
    [ApiController]
    
    public class PostController : ControllerBase
    {
        
        public DbPostContext db;
        public PostController(DbPostContext db)
        {
            this.db = db;
        }



      
       
        [Route("api/allPost")]
        [HttpGet]
        public IEnumerable<PostMessage> GetAllPosts()
        {
            var posts = (from p in db.postMessageData select p).ToList();
            foreach (PostMessage p in posts)
            {
                p.Comment = this.GetComments(p.Id);
            }
            return posts;
        }


        [Route("api/postById/{id}")]
        [HttpGet]
        public PostMessage GetPostById(int id)
        {

            var data= db.postMessageData.Find(id);
            data.Comment = this.GetComments(data.Id);
            return data;


        }

        [Route("api/post/likes/{id}")]
        [HttpGet]
        public int GetLikesById(int id)
        {
            return db.postMessageData.Find(id).Total_Likes;
        }

        [Route("api/post/comment/{id}")]
        [HttpGet]
        public List<CommentMessage> GetComments(int id)
        {
            return db.postMessageData.Where(p => p.Id == id).Select(p => p.Comment).First();

        }

        [Route("api/addPost")]

        [HttpPost]
        public PostMessage AddPost(PostMessage newValue)
        {
           
            db.postMessageData.Add(newValue);
            db.SaveChanges();
            return newValue;
        }

        [Route("api/addComment/{id}")]
        [HttpPost]
        public CommentMessage CommentAdd(CommentMessage commentAdd, int Id)
        {
            var obj = db.postMessageData.Find(Id);
            if (obj.Comment == null)
            {
                obj.Comment = new List<CommentMessage>() { commentAdd };
            }
            else
            {
                obj.Comment.Add(commentAdd);
            }

            db.postMessageData.Update(obj);
            db.SaveChanges();
            return commentAdd;
        }

        [Route("api/addLike/{id}")]
        [HttpPut]
        public int Likes(int id)
        {
            if (db.postMessageData.Find(id).Total_Likes.Equals(null))
            {
                db.postMessageData.Find(id).Total_Likes = 1;
            }
            else
            {
                db.postMessageData.Find(id).Total_Likes = db.postMessageData.Find(id).Total_Likes + 1;
            }
            db.SaveChanges();
            return db.postMessageData.Find(id).Total_Likes;
        }



    }


     
}