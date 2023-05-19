using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Lesson012_UsingTagHelper.Utils
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("tr", Attributes = "bg-color,text-color", ParentTag = "thead")]
    public class MyTagHelper : TagHelper
    {
        public string BgColor { get; set; } = "dark";
        public string TextColor { get; set; } = "white";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class",
                $"bg-{BgColor} text-center text-{TextColor}"
                );
        }
    }
}
