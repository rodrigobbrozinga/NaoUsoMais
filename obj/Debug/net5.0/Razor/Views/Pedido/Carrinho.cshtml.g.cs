#pragma checksum "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d250e892d76567de89f0c0a1797b9103230e92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Carrinho), @"mvc.1.0.view", @"/Views/Pedido/Carrinho.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28d250e892d76567de89f0c0a1797b9103230e92", @"/Views/Pedido/Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"328cdb724acd59ed07bee39e664f156f55484068", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ItemPedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "catalogo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "resumo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Carrinho.cshtml"
  
    ViewData["Title"] = "Carrinho";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""ajusta-cabecalho"">Carrinho</h2>

<div class=""card border-primary p-3"">
    <div class=""card-header"">

        <div class=""row"">
            <div class=""col-md-6"">
                Item
            </div>
            <div class=""col-md-2 text-center"">
                Preço Unitário
            </div>
            <div class=""col-md-2 text-center"">
                Quantidade
            </div>
            <div class=""col-md-2"">
                <span class=""pull-right"">
                    Subtotal
                </span>
            </div>
        </div>
    </div>
    <div class=""card-body"">

");
#nullable restore
#line 30 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Carrinho.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row row-center linha-produto align-items-center\">\r\n                <div class=\"col-md-3\">\r\n                    <img class=\"img-produto-carrinho\"");
            BeginWriteAttribute("src", " src=\"", 922, "\"", 970, 3);
            WriteAttributeValue("", 928, "/images/produto_", 928, 16, true);
#nullable restore
#line 34 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 944, item.Produto.Codigo, 944, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 966, ".jpg", 966, 4, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-3\">");
#nullable restore
#line 36 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Carrinho.cshtml"
                                  Write(item.Produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col-md-2 text-center\">R$ ");
#nullable restore
#line 37 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Carrinho.cshtml"
                                                 Write(item.PrecoUnitario);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                <div class=""col-md-2 text-center"">
                    <div class=""input-group"">
                        <span class=""input-group-btn"">
                            <button class=""btn btn-dark"">
                                <span>-</span>
                            </button>
                        </span>
                        <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 1524, "\"", 1550, 1);
#nullable restore
#line 45 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Carrinho.cshtml"
WriteAttributeValue("", 1532, item.Quantidade, 1532, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                               class=""form-control text-center"" />
                        <span class=""input-group-btn"">
                            <button class=""btn btn-dark"">
                                <span>+</span>
                            </button>
                        </span>
                    </div>
                </div>
                <div class=""col-md-2"">
                    R$ <span class=""pull-right"" subtotal>
                        ");
#nullable restore
#line 56 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Carrinho.cshtml"
                    Write(item.Quantidade * item.PrecoUnitario);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 60 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Carrinho.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"card-footer\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-10\">\r\n                <span numero-itens>\r\n                    Total: ");
#nullable restore
#line 66 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Carrinho.cshtml"
                       Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    itens\r\n                </span>\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                Total: R$ <span class=\"pull-right\" total>\r\n                    ");
#nullable restore
#line 72 "C:\Users\bots_\source\repos\NaoUsoMais\NaoUsoMais\Views\Pedido\Carrinho.cshtml"
                Write(Model.Sum(i => i.Quantidade * i.PrecoUnitario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row mt-3\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"pull-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d250e892d76567de89f0c0a1797b9103230e929372", async() => {
                WriteLiteral("\r\n                Adicionar Produtos\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d250e892d76567de89f0c0a1797b9103230e9210670", async() => {
                WriteLiteral("\r\n                FInalizar Pedido\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<ItemPedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
