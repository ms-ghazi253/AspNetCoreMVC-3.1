using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgentle.BookStore.Helper
{
    public class BigTagHelper:TagHelper
    {
        //[HtmlTargetElement("big", Attributes = "big")]
        //[HtmlTargetElement(Attributes ="big")]
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h3";
            output.Attributes.RemoveAll("big");

        }
    }
}
