using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MessageBoard.Pages.Post
{
    public class CommentModel : PageModel
    {
        private readonly PostMessageData postMessageData;
        public PostMessage postMessage { get; set; }
        [BindProperty]
        public CommentMessage commentMessage { get; set; }
        public CommentModel(PostMessageData postMessageData)
        {
            this.postMessageData = postMessageData;
        }
        public void OnGet(int resId)
        {
            postMessage = postMessageData.GetPostById(resId);
        }

        public IActionResult OnPost(int resId)
        {
            postMessage = postMessageData.GetPostById(resId);
            if (postMessage.Id>0)
            {
                postMessageData.CommentAdd(commentMessage, resId);
            }
            return RedirectToPage("./List");
        }
    }
}