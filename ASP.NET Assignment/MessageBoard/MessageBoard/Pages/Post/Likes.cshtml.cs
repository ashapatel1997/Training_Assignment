using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MessageBoard.Pages.Post
{
    public class LikesModel : PageModel
    {
        private readonly PostMessageData postMessageData;

        public LikesModel(PostMessageData postMessageData)
        {
            this.postMessageData = postMessageData;
        }
        public IActionResult OnGet(int resId)
        {
         
            
                postMessageData.Likes(resId);
            
            
            return RedirectToPage("./List");
        }
    }
}