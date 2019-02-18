using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard
{
    public interface PostMessageData
    {

        IEnumerable<PostMessage> GetPosts();
        List<CommentMessage> GetComments(int id);
        PostMessage Add(PostMessage newValue);
        int Commit();
        PostMessage GetPostById(int id);
        CommentMessage CommentAdd(CommentMessage commentAdd, int Id);
        int Likes(int id);
    }
}
