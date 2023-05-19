using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Lesson012_UsingTagHelper.Utils
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("tableHead")]
    public class TableHeadTagHelper : TagHelper
    {
        public string BgColor { get; set; } = "dark";

        public override async void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "thead";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("class", $"bg-{BgColor} text-white text-center");

            string content = (await output.GetChildContentAsync()).GetContent();
            output.Content.SetHtmlContent($"<tr><th colspan=\"2\">{content}</th></tr>");
        }
    }
}
