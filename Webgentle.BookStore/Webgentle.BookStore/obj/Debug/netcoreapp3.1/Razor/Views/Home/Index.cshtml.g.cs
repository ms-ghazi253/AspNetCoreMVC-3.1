#pragma checksum "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e056c30e8f67c41abbed5c24372f3d7ae2de223d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\_ViewImports.cshtml"
using Webgentle.BookStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\_ViewImports.cshtml"
using Webgentle.BookStore.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e056c30e8f67c41abbed5c24372f3d7ae2de223d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d901b5c2680460962f2b145d751ed35eedfd12b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Webgentle.BookStore.Helper.BigTagHelper __Webgentle_BookStore_Helper_BigTagHelper;
        private global::AspNetCore.Views_Home_Index.__Generated__TopBooksViewComponentTagHelper __TopBooksViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Home\Index.cshtml"
   
    var book = ViewData["Book"] as BookModel;

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"jumbotron text-center\">\r\n    <div class=\"container\">\r\n        <h1 class=\"h1\"> welcom to Bookstore ");
            WriteLiteral("  ");
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Home\Index.cshtml"
                                                                                      Write(ViewData["CustomPeroperty"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n       <h1 class=\"h1\">Id=");
#nullable restore
#line 17 "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Home\Index.cshtml"
                    Write(book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n       <h1 class=\"h1\">Title=");
#nullable restore
#line 18 "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Home\Index.cshtml"
                       Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p class=\"lead text-muted\">\r\n");
            WriteLiteral(@"            orem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
        </p>
        <p href=""#"" class=""btn btn-primary my-2"">Search books</p>
    </div>
</section>

<div class=""container"">
    
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("big", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e056c30e8f67c41abbed5c24372f3d7ae2de223d5504", async() => {
                WriteLiteral("Top books");
            }
            );
            __Webgentle_BookStore_Helper_BigTagHelper = CreateTagHelper<global::Webgentle.BookStore.Helper.BigTagHelper>();
            __tagHelperExecutionContext.Add(__Webgentle_BookStore_Helper_BigTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <p big>Top book using attribute</p>\r\n");
            WriteLiteral("\r\n           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:top-books", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e056c30e8f67c41abbed5c24372f3d7ae2de223d6515", async() => {
            }
            );
            __TopBooksViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Home_Index.__Generated__TopBooksViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__TopBooksViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  \r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n    <script>\r\n        $(document).Read(function () {\r\n            alert(\"document is ready\");\r\n        })\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:top-books")]
        public class __Generated__TopBooksViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__TopBooksViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("TopBooks", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
