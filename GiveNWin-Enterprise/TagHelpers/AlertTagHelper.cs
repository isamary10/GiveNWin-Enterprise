using Microsoft.AspNetCore.Razor.TagHelpers;

namespace GiveNWin_Enterprise.TagHelpers
{
	public class AlertTagHelper : TagHelper
	{
        public string? Mensagem { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!string.IsNullOrEmpty(Mensagem))
            {
                output.TagName = "div";
                output.Attributes.SetAttribute("class", "alert alert-success");
                output.Content.SetContent(Mensagem);
            }
        }
    }
}
