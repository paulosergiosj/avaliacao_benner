#pragma checksum "C:\Users\Paulo\Documents\Avaliação Benner\MicroondasMVC\MicroondasMVC\Views\AquecimentoPadrao\BuscaAquecimento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2674aa1c48c000f649c796c8db64f3e32e8d5999"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AquecimentoPadrao_BuscaAquecimento), @"mvc.1.0.view", @"/Views/AquecimentoPadrao/BuscaAquecimento.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AquecimentoPadrao/BuscaAquecimento.cshtml", typeof(AspNetCore.Views_AquecimentoPadrao_BuscaAquecimento))]
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
#line 1 "C:\Users\Paulo\Documents\Avaliação Benner\MicroondasMVC\MicroondasMVC\Views\_ViewImports.cshtml"
using MicroondasMVC;

#line default
#line hidden
#line 2 "C:\Users\Paulo\Documents\Avaliação Benner\MicroondasMVC\MicroondasMVC\Views\_ViewImports.cshtml"
using MicroondasMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2674aa1c48c000f649c796c8db64f3e32e8d5999", @"/Views/AquecimentoPadrao/BuscaAquecimento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf8e0fb75d944f9dc49f1916fa7d89e45358d6f4", @"/Views/_ViewImports.cshtml")]
    public class Views_AquecimentoPadrao_BuscaAquecimento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MicroondasMVC.Models.Aquecimento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AquecimentoPadrao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Aquecer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bottom-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Paulo\Documents\Avaliação Benner\MicroondasMVC\MicroondasMVC\Views\AquecimentoPadrao\BuscaAquecimento.cshtml"
  
    ViewData["Title"] = "Resultado da busca";

#line default
#line hidden
            BeginContext(101, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(108, 17, false);
#line 6 "C:\Users\Paulo\Documents\Avaliação Benner\MicroondasMVC\MicroondasMVC\Views\AquecimentoPadrao\BuscaAquecimento.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(125, 747, true);
            WriteLiteral(@"</h2>

<div>
    <table class=""table"">
        <thead>
            <tr class=""success"">
                <th>
                    <h6 type=""text"" class=""text-info"">Nome</h6>
                </th>
                <th>
                    <h6 type=""text"" class=""text-info"">Alimento</h6>
                </th>
                <th>
                    <h6 type=""text"" class=""text-info"">Instruções de Uso</h6>
                </th>
                <th>
                    <h6 type=""text"" class=""text-info"">Tempo</h6>
                </th>
                <th>
                    <h6 type=""text"" class=""text-info"">Potencia</h6>
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 31 "C:\Users\Paulo\Documents\Avaliação Benner\MicroondasMVC\MicroondasMVC\Views\AquecimentoPadrao\BuscaAquecimento.cshtml"
             foreach (AquecimentoPadrao item in Model)
            {

#line default
#line hidden
            BeginContext(943, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1016, 39, false);
#line 35 "C:\Users\Paulo\Documents\Avaliação Benner\MicroondasMVC\MicroondasMVC\Views\AquecimentoPadrao\BuscaAquecimento.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1135, 43, false);
#line 38 "C:\Users\Paulo\Documents\Avaliação Benner\MicroondasMVC\MicroondasMVC\Views\AquecimentoPadrao\BuscaAquecimento.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Alimento));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1258, 45, false);
#line 41 "C:\Users\Paulo\Documents\Avaliação Benner\MicroondasMVC\MicroondasMVC\Views\AquecimentoPadrao\BuscaAquecimento.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Instrucoes));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1383, 40, false);
#line 44 "C:\Users\Paulo\Documents\Avaliação Benner\MicroondasMVC\MicroondasMVC\Views\AquecimentoPadrao\BuscaAquecimento.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Tempo));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1503, 43, false);
#line 47 "C:\Users\Paulo\Documents\Avaliação Benner\MicroondasMVC\MicroondasMVC\Views\AquecimentoPadrao\BuscaAquecimento.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Potencia));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1625, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bf7b124be344a0b9e5f3c35f8123b48", async() => {
                BeginContext(1652, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1682, 124, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7899823c36d24362917b26cadc21d3f2", async() => {
                    BeginContext(1786, 16, true);
                    WriteLiteral("Inserir Alimento");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Paulo\Documents\Avaliação Benner\MicroondasMVC\MicroondasMVC\Views\AquecimentoPadrao\BuscaAquecimento.cshtml"
                                                                    WriteLiteral(item.ID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1806, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1839, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 55 "C:\Users\Paulo\Documents\Avaliação Benner\MicroondasMVC\MicroondasMVC\Views\AquecimentoPadrao\BuscaAquecimento.cshtml"
            }

#line default
#line hidden
            BeginContext(1906, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MicroondasMVC.Models.Aquecimento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
