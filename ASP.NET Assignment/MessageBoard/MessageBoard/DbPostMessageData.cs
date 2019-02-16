using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard
{
    public class DbPostMessageData:PostMessageData
    {
        private readonly DbPostDataContext db;

        public DbPostMessageData(DbPostDataContext db)
        {
            this.db = db;
        }
        public PostMessage Add(PostMessage newValue)
        {
            db.Add(newValue);
            return newValue;
        }

      
        public IEnumerable<PostMessage> GetPosts()
        {
            return from p in db.postMessage select p;
        }


       public PostMessage GetPostById(int id)
        {
            return db.postMessage.Find(id);
        }

        //public CommentMessage CommentAdd(CommentMessage commentAdd)
        //{
        //    var updated = db.commentMessage.Add(commentAdd);
        //    updated.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    return commentAdd;
        //}
        public int Commit()
        {
            return db.SaveChanges();
        }

        public CommentMessage CommentAdd(CommentMessage commentAdd, int Id)
        {
            var obj = db.postMessage.Find(Id);
            if (obj.Comment == null)
            {
                obj.Comment = new List<CommentMessage>() { commentAdd };
            }
            else
            {
                obj.Comment.Add(commentAdd);
            }
            
            db.postMessage.Update(obj);
            db.SaveChanges();
            return commentAdd;
        }

        //public int totalCount()
        //{
        //    throw new NotImplementedException();
        //}

        public int Likes(int id)
        {
            if (db.postMessage.Find(id).Total_Likes.Equals(null))
            {
                db.postMessage.Find(id).Total_Likes = 1;
            }
            else
            {
                db.postMessage.Find(id).Total_Likes = db.postMessage.Find(id).Total_Likes + 1;
            }
            db.SaveChanges();
            return db.postMessage.Find(id).Total_Likes;
        }
    }
}
