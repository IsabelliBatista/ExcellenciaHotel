#pragma checksum "C:\Users\Isabelli Batista\Source\Repos\IsabelliBatista\ExcellenciaHotel\PIM_\PIM_\Views\DadosPessoais\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e36b69c300831c47792d67bacdc348a4f3a814d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DadosPessoais_Index), @"mvc.1.0.view", @"/Views/DadosPessoais/Index.cshtml")]
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
#line 1 "C:\Users\Isabelli Batista\Source\Repos\IsabelliBatista\ExcellenciaHotel\PIM_\PIM_\Views\_ViewImports.cshtml"
using PIM_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Isabelli Batista\Source\Repos\IsabelliBatista\ExcellenciaHotel\PIM_\PIM_\Views\_ViewImports.cshtml"
using PIM_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e36b69c300831c47792d67bacdc348a4f3a814d", @"/Views/DadosPessoais/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7740c30184785a3cbc99bf92eb7026de3dfb73b4", @"/Views/_ViewImports.cshtml")]
    public class Views_DadosPessoais_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Isabelli Batista\Source\Repos\IsabelliBatista\ExcellenciaHotel\PIM_\PIM_\Views\DadosPessoais\Index.cshtml"
  
    ViewData["Title"] = "Dados Pessoais";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e36b69c300831c47792d67bacdc348a4f3a814d4237", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 126, "\"", 166, 1);
#nullable restore
#line 7 "C:\Users\Isabelli Batista\Source\Repos\IsabelliBatista\ExcellenciaHotel\PIM_\PIM_\Views\DadosPessoais\Index.cshtml"
WriteAttributeValue("", 133, Url.Content("~/css/checkin.css"), 133, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e36b69c300831c47792d67bacdc348a4f3a814d5664", async() => {
                WriteLiteral("\r\n    <div class=\"banner-dados-pessoais\">\r\n        <h2 class=\"h2 fw-bolder\">Meus Dados</h2>\r\n    </div>\r\n<div class=\"formularios mt-5 mb-5\">\r\n    <div class=\"container\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e36b69c300831c47792d67bacdc348a4f3a814d6117", async() => {
                    WriteLiteral(@"
            <div class=""col"">
                <h5>Dados pessoais</h5>
                <div class=""mb-3"">
                    <label for=""formGroupExampleInput"" class=""form-label"">Nome</label>
                    <input type=""text"" class=""form-control"" id=""formGroupExampleInput"" placeholder=""Nome completo"">
                </div>
                <div class=""mb-3"">
                    <label for=""formGroupExampleInput2"" class=""form-label"">Telefone</label>
                    <input type=""text"" class=""form-control"" id=""formGroupExampleInput2"" placeholder=""+55 11 9 1234-1234"">
                </div>
                <div class=""mb-3"">
                    <label for=""formGroupExampleInput2"" class=""form-label"">CPF</label>
                    <input type=""text"" class=""form-control"" id=""formGroupExampleInput2"" placeholder=""999.999.999.99"">
                </div>
                <div class=""col-12"">
                    <button type=""submit"" class=""btn btn-primary"">Editar -></button>
                </");
                    WriteLiteral(@"div>
            </div>
            <div class=""col"">
                <h5>Dados da Conta</h5>
                <div class=""mb-3"">
                    <label for=""formGroupExampleInput"" class=""form-label"">Email</label>
                    <input type=""email"" class=""form-control"" id=""formGroupExampleInput"" placeholder=""email@gmail.com"">
                </div>
                <div class=""mb-3"">
                    <label for=""formGroupExampleInput2"" class=""form-label"">Senha</label>
                    <input type=""password"" class=""form-control"" id=""formGroupExampleInput2"" placeholder=""*********"">
                </div>

                <div class=""col-12"">
                    <button type=""submit"" class=""btn btn-primary"">Mudar dados -></button>
                </div>
            </div>

        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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