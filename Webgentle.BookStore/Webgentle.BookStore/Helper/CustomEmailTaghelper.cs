using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgentle.BookStore.Helper
{
    public class CustomEmailTaghelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:ms.ghazi253@gmail.com");
            output.Attributes.Add("Id", "My-email-id");
            output.Content.SetContent("My-email");
        }
    }
}
