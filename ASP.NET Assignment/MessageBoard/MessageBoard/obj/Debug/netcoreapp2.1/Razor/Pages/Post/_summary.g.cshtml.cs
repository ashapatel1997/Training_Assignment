#pragma checksum "C:\Users\asha\Documents\asha\Training\C#\Training_Assignment\ASP.NET Assignment\MessageBoard\MessageBoard\Pages\Post\_summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68e60e1933d41a82ed3ab57025ac1ba255a3a284"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MessageBoard.Pages.Post.Pages_Post__summary), @"mvc.1.0.view", @"/Pages/Post/_summary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Post/_summary.cshtml", typeof(MessageBoard.Pages.Post.Pages_Post__summary))]
namespace MessageBoard.Pages.Post
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\asha\Documents\asha\Training\C#\Training_Assignment\ASP.NET Assignment\MessageBoard\MessageBoard\Pages\_ViewImports.cshtml"
using MessageBoard;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68e60e1933d41a82ed3ab57025ac1ba255a3a284", @"/Pages/Post/_summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b372d9d6b7be86b7c4a24fac07cccb0ed0785ffc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Post__summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostMessage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Likes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(22, 85, true);
            WriteLiteral("\r\n<div class=\"panel panel-default\">\r\n    <div class=\"panel-heading\">\r\n        <h3>Id:");
            EndContext();
            BeginContext(108, 8, false);
#line 6 "C:\Users\asha\Documents\asha\Training\C#\Training_Assignment\ASP.NET Assignment\MessageBoard\MessageBoard\Pages\Post\_summary.cshtml"
          Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(116, 71, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <span>Message:");
            EndContext();
            BeginContext(188, 13, false);
#line 9 "C:\Users\asha\Documents\asha\Training\C#\Training_Assignment\ASP.NET Assignment\MessageBoard\MessageBoard\Pages\Post\_summary.cshtml"
                 Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(201, 70, true);
            WriteLiteral("</span>\r\n\r\n    </div>\r\n    <div class=\"panel-body\">\r\n\r\n        <div>\r\n");
            EndContext();
#line 15 "C:\Users\asha\Documents\asha\Training\C#\Training_Assignment\ASP.NET Assignment\MessageBoard\MessageBoard\Pages\Post\_summary.cshtml"
             if (Model.Comment != null)
            {
            

#line default
#line hidden
#line 17 "C:\Users\asha\Documents\asha\Training\C#\Training_Assignment\ASP.NET Assignment\MessageBoard\MessageBoard\Pages\Post\_summary.cshtml"
             foreach (CommentMessage cmt in Model.Comment)
            {

#line default
#line hidden
            BeginContext(402, 22, true);
            WriteLiteral("                <span>");
            EndContext();
            BeginContext(425, 11, false);
#line 19 "C:\Users\asha\Documents\asha\Training\C#\Training_Assignment\ASP.NET Assignment\MessageBoard\MessageBoard\Pages\Post\_summary.cshtml"
                 Write(cmt.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(436, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 20 "C:\Users\asha\Documents\asha\Training\C#\Training_Assignment\ASP.NET Assignment\MessageBoard\MessageBoard\Pages\Post\_summary.cshtml"
            }

#line default
#line hidden
#line 20 "C:\Users\asha\Documents\asha\Training\C#\Training_Assignment\ASP.NET Assignment\MessageBoard\MessageBoard\Pages\Post\_summary.cshtml"
             
            }

#line default
#line hidden
            BeginContext(475, 33, true);
            WriteLiteral("        </div>\r\n       \r\n        ");
            EndContext();
            BeginContext(508, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e0a98e9c249462fb8f641d2c07f49d0", async() => {
                BeginContext(584, 11, true);
                WriteLiteral("Add Comment");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-resId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\asha\Documents\asha\Training\C#\Training_Assignment\ASP.NET Assignment\MessageBoard\MessageBoard\Pages\Post\_summary.cshtml"
                                                             WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["resId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-resId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["resId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(599, 52, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n    <div class=\"panel-footer\">\r\n");
            EndContext();
            BeginContext(833, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(841, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e2ac3023bee4b098aba536af3fa5910", async() => {
                BeginContext(916, 4, true);
                WriteLiteral("Like");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-resId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\asha\Documents\asha\Training\C#\Training_Assignment\ASP.NET Assignment\MessageBoard\MessageBoard\Pages\Post\_summary.cshtml"
                                                            WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["resId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-resId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["resId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(924, 52, true);
            WriteLiteral("\r\n        <label style=\"float:right;font-size:20px\">");
            EndContext();
            BeginContext(977, 17, false);
#line 32 "C:\Users\asha\Documents\asha\Training\C#\Training_Assignment\ASP.NET Assignment\MessageBoard\MessageBoard\Pages\Post\_summary.cshtml"
                                             Write(Model.Total_Likes);

#line default
#line hidden
            EndContext();
            BeginContext(994, 50, true);
            WriteLiteral("</label>\r\n\r\n        <br />\r\n\r\n    </div>\r\n\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
