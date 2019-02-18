using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MessageBoard.Pages.Shared.Post
{
    public class ListModel : PageModel
    {
        private readonly PostMessageData postMessageData;
       
        public IEnumerable<PostMessage> PostMessage { get; set; }
        public ListModel(PostMessageData postMessageData)
        {
            this.postMessageData = postMessageData;
        }

        public void OnGet(int resId)
        {
            PostMessage = postMessageData.GetPosts();

        }
        

      
    }
}