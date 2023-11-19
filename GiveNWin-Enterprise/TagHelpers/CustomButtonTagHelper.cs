using Microsoft.AspNetCore.Razor.TagHelpers;

namespace GiveNWin_Enterprise.TagHelpers
{
    public class CustomButtonTagHelper : TagHelper
    {
        public string? Texto { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.Content.SetContent(string.IsNullOrEmpty(Texto) ? "Cadastrar" : Texto);
            if (!string.IsNullOrEmpty(Texto) && Texto.Equals("Remover"))
            {
                output.Attributes.SetAttribute("class", "btn btn-danger");
            }
            else
            {
                output.Attributes.SetAttribute("class", "btn btn-primary");
            }

        }
    }
}
