#pragma checksum "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb0ad6ade64c7aec2c7f1b575db448e1aff552bf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb0ad6ade64c7aec2c7f1b575db448e1aff552bf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b63cfba34ea52b5385c1b1401eb26f9b73f7c04e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Home\Index.cshtml"
   
    dynamic Data = ViewBag.Data;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"jumbotron text-center\">\r\n    <div class=\"container\">\r\n        <h1 class=\"h1\"> welcom to Bookstore ");
#nullable restore
#line 11 "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Home\Index.cshtml"
                                       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <p class=\"lead text-muted\">\r\n            ");
#nullable restore
#line 13 "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Home\Index.cshtml"
       Write(Data.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Home\Index.cshtml"
                Write(Data.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            id= ");
#nullable restore
#line 14 "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Home\Index.cshtml"
           Write(ViewBag.Type.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            Name= ");
#nullable restore
#line 15 "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Home\Index.cshtml"
             Write(ViewBag.Type.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
            orem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
        </p>
        <p href=""#"" class=""btn btn-primary my-2"">Search books</p>
    </div>
</section>

<div class=""container"">
    <div class=""row row-cols-1 row-cols-md-3 g-4 "">
        <div class=""col"">
            <div class=""card h-100"">
                <img src=""..."" class=""card-img-top"" alt=""..."">
                <div class=""card-body"">
                    <h5 class=""card-title"">Card title</h5>
              ");
            WriteLiteral(@"      <p class=""card-text"">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""card h-100"">
                <img src=""..."" class=""card-img-top"" alt=""..."">
                <div class=""card-body"">
                    <h5 class=""card-title"">Card title</h5>
                    <p class=""card-text"">This is a short card.</p>
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""card h-100"">
                <img src=""..."" class=""card-img-top"" alt=""..."">
                <div class=""card-body"">
                    <h5 class=""card-title"">Card title</h5>
                    <p class=""card-text"">This is a longer card with supporting text below as a natural lead-in to additional content.</p>
                </div>
            </div>
        </div>
        <div cl");
            WriteLiteral(@"ass=""col"">
            <div class=""card h-100"">
                <img src=""..."" class=""card-img-top"" alt=""..."">
                <div class=""card-body"">
                    <h5 class=""card-title"">Card title</h5>
                    <p class=""card-text"">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
    }
}
#pragma warning restore 1591
