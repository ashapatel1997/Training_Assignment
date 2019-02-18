using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MessageBoard.Pages.Shared.Post
{
    public class EditModel : PageModel
    {
        private readonly PostMessageData postMessageData;

        [BindProperty]
        public PostMessage PostMessage { get; set; }
        public EditModel(PostMessageData postMessageData)
        {
            this.postMessageData = postMessageData;
        }

        public IActionResult OnGet(int? id)
        {

            PostMessage = new PostMessage();


            if (PostMessage == null)
                return RedirectToPage("./PageNotFound");
            else
                return Page();
        }
        public IActionResult OnPost()
        {

            postMessageData.Add(PostMessage);
            postMessageData.Commit();
            return RedirectToPage("./List");

        }
    }
}
    