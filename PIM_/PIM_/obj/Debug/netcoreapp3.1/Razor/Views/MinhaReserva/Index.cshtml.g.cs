#pragma checksum "C:\Users\Isabelli Batista\Source\Repos\IsabelliBatista\ExcellenciaHotel\PIM_\PIM_\Views\MinhaReserva\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69590e58e93cc504378ed2fdacd223dc54047c30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MinhaReserva_Index), @"mvc.1.0.view", @"/Views/MinhaReserva/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69590e58e93cc504378ed2fdacd223dc54047c30", @"/Views/MinhaReserva/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7740c30184785a3cbc99bf92eb7026de3dfb73b4", @"/Views/_ViewImports.cshtml")]
    public class Views_MinhaReserva_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Isabelli Batista\Source\Repos\IsabelliBatista\ExcellenciaHotel\PIM_\PIM_\Views\MinhaReserva\Index.cshtml"
  
    ViewData["Title"] = "Minha Reserva";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69590e58e93cc504378ed2fdacd223dc54047c303596", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\"");
                BeginWriteAttribute("href", " href=\"", 87, "\"", 127, 1);
#nullable restore
#line 7 "C:\Users\Isabelli Batista\Source\Repos\IsabelliBatista\ExcellenciaHotel\PIM_\PIM_\Views\MinhaReserva\Index.cshtml"
WriteAttributeValue("", 94, Url.Content("~/css/checkin.css"), 94, 33, false);

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
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69590e58e93cc504378ed2fdacd223dc54047c305027", async() => {
                WriteLiteral(@"
    <!-- <header class=""navbar navbar-expand-lg navbar-light pt-3 pb-3"">
           <div class=""container"">
               <img src=""../img/Logo_PIM.png"" alt="""" class=""logo"">
               <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse""
                       data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false""
                       aria-label=""Toggle navigation"">
                   <span class=""navbar-toggler-icon""></span>
               </button>
               <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                   <ul class=""navbar-nav mx-auto mb-2 mb-lg-2"">
                       <li class=""nav-item px-2"">
                           <a class=""nav-link"" aria-current=""page"" href=""#"">Home</a>
                       </li>
                       <li class=""nav-item px-2"">
                           <a class=""nav-link"" aria-current=""page"" href=""#"">Acomodações</a>
                       </li>");
                WriteLiteral(@"
                       <li class=""nav-item px-2"">
                           <a class=""nav-link"" aria-current=""page"" href=""#"">Lazer</a>
                       </li>
                       <li class=""nav-item px-2"">
                           <a class=""nav-link"" aria-current=""page"" href=""#"">Galeria</a>
                       </li>
                       <li class=""nav-item px-2"">
                           <a class=""nav-link"" aria-current=""page"" href=""#"">Contato</a>
                       </li>
                   </ul>
                   <form class=""d-flex"">
                       <button class=""btn btn-success me-2"" type=""submit"">Perfil</button>
                       <button class=""btn btn-outline-danger"" type=""submit"">Sair</button>
                   </form>
               </div>
           </div>
       </header> -->
    <div class=""banner-reserva"">
        <h2 class=""h2 fw-bolder"">Minha Reserva</h2>
    </div>
    <main>
        <div class=""container"">
            <div class=""row ");
                WriteLiteral(@"g-0 bg-light position-relative p-4 mt-5"">
                <div class=""row"">
                    <div class=""col border p-2"">
                        <h5 class=""mt-0 fw-bolder"">Número da minha reserva</h5>
                        <p> 123</p>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col border p-2"">
                        <h5 class=""mt-0 fw-bolder"">Quarto Family</h5>
                        <p>3 Camas, 2 banheiros, uma sala, uma área de lazer, em frente da piscina</p>
                    </div>
                    <div class=""col border p-2"">
                        <h5 class=""mt-0 fw-bolder"">Quantidade de Pessoas</h5>
                        <p>3</p>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col border p-2"">
                        <h5 class=""mt-0 fw-bolder"">Check In</h5>
                        <p>01/11/2021</p>
                    </div>
 ");
                WriteLiteral(@"                   <div class=""col border p-2"">
                        <h5 class=""mt-0 fw-bolder"">Check Out</h5>
                        <p>05/11/2021</p>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col border p-2"">
                        <h5 class=""mt-0 fw-bolder"">Diárias</h5>
                        <p>5</p>
                    </div>
                    <div class=""col border p-2"">
                        <h5 class=""mt-0 fw-bolder"">Total</h5>
                        <p>R$ 00,00</p>
                    </div>
                </div>
            </div>
            <div class=""d-grid gap-2 d-md-flex btn-enviar justify-content-md-end"">

                <button class=""btn btn-warning btn-lg"" type=""button"">Mudar Data</button>
                <button class=""btn btn-danger btn-lg"" type=""button"">Cancelar Reserva</button>

            </div>

        </div>
    </main>
");
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
