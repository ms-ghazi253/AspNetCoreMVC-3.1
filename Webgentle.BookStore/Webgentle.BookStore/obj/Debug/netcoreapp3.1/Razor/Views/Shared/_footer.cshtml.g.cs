#pragma checksum "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Shared\_footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c2e6d52c72b54fef3bd1deab71f2419cbc7094"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__footer), @"mvc.1.0.view", @"/Views/Shared/_footer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c2e6d52c72b54fef3bd1deab71f2419cbc7094", @"/Views/Shared/_footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d901b5c2680460962f2b145d751ed35eedfd12b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-for", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Webgentle.BookStore.Helper.CustomEmailTaghelper __Webgentle_BookStore_Helper_CustomEmailTaghelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<footer class=\"border-top footer text-muted text-center \">\r\n    <div class=\"container\">\r\n        CopyRight  &copy; Book Store ");
#nullable restore
#line 3 "C:\Users\fahim\Desktop\ASP\AspNetCoreMVC-3.1\Webgentle.BookStore\Webgentle.BookStore\Views\Shared\_footer.cshtml"
                                Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a href=\"mailto:ms.ghazi253@gmail.com\"></a>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("custom-email", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99c2e6d52c72b54fef3bd1deab71f2419cbc70944013", async() => {
            }
            );
            __Webgentle_BookStore_Helper_CustomEmailTaghelper = CreateTagHelper<global::Webgentle.BookStore.Helper.CustomEmailTaghelper>();
            __tagHelperExecutionContext.Add(__Webgentle_BookStore_Helper_CustomEmailTaghelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</footer>");
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
