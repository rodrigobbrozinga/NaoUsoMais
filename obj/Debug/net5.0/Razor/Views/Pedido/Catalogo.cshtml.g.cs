#pragma checksum "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Catalogo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1406bc6765962d8612a4e124c29e81453d383f1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Catalogo), @"mvc.1.0.view", @"/Views/Pedido/Catalogo.cshtml")]
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
#line 1 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\_ViewImports.cshtml"
using NaoUsoMais;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\_ViewImports.cshtml"
using NaoUsoMais.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1406bc6765962d8612a4e124c29e81453d383f1f", @"/Views/Pedido/Catalogo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"328cdb724acd59ed07bee39e664f156f55484068", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Catalogo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Catalogo.cshtml"
  
    ViewData["Title"] = "Catalogo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2 class=\"ajusta-cabecalho mb-4\">Catálogo</h2>\r\n\r\n<div class=\"d-flex justify-content-around\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Catalogo.cshtml"
     foreach (var produto in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card border-primary d-flex mb-3 d-inline-block posicao-card\" style=\"max-width: 20rem;\">\r\n        <div class=\"card-header\">\r\n            <img class=\"imagem_produto\"");
            BeginWriteAttribute("src", " src=\"", 392, "\"", 435, 3);
            WriteAttributeValue("", 398, "/images/produto_", 398, 16, true);
#nullable restore
#line 15 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Catalogo.cshtml"
WriteAttributeValue("", 414, produto.Codigo, 414, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 431, ".jpg", 431, 4, true);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Imagem do produto\" />\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <h4 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Catalogo.cshtml"
                              Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Catalogo.cshtml"
                            Write(produto.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"card-footer d-flex flex-row justify-content-between align-items-baseline posicao-footer\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1406bc6765962d8612a4e124c29e81453d383f1f5819", async() => {
                WriteLiteral("Comprar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-codigo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Catalogo.cshtml"
                                           WriteLiteral(produto.Codigo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-codigo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <h4>R$ ");
#nullable restore
#line 23 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Catalogo.cshtml"
              Write(produto.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Catalogo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
