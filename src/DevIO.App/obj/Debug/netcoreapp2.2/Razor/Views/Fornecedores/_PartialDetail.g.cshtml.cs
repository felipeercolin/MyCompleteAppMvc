#pragma checksum "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\MyCompleteAppMvc\src\DevIO.App\Views\Fornecedores\_PartialDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d07073ab44986b5b061525fa32354ba356f41713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedores__PartialDetail), @"mvc.1.0.view", @"/Views/Fornecedores/_PartialDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fornecedores/_PartialDetail.cshtml", typeof(AspNetCore.Views_Fornecedores__PartialDetail))]
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
#line 1 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\MyCompleteAppMvc\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App;

#line default
#line hidden
#line 1 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\MyCompleteAppMvc\src\DevIO.App\Views\Fornecedores\_PartialDetail.cshtml"
using DevIO.App.Extentions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07073ab44986b5b061525fa32354ba356f41713", @"/Views/Fornecedores/_PartialDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f0c23ab3d0304c5197a32055a22f3cad21c02c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedores__PartialDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevIO.App.ViewModels.FornecedorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PartialEndereco", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 53, true);
            WriteLiteral("<dl class=\"row\">\r\n    <dt class=\"col-sm-2\">\r\n        ");
            EndContext();
            BeginContext(132, 40, false);
#line 5 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\MyCompleteAppMvc\src\DevIO.App\Views\Fornecedores\_PartialDetail.cshtml"
   Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(172, 49, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
            EndContext();
            BeginContext(222, 36, false);
#line 8 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\MyCompleteAppMvc\src\DevIO.App\Views\Fornecedores\_PartialDetail.cshtml"
   Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(258, 48, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
            EndContext();
            BeginContext(307, 45, false);
#line 11 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\MyCompleteAppMvc\src\DevIO.App\Views\Fornecedores\_PartialDetail.cshtml"
   Write(Html.DisplayNameFor(model => model.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(352, 49, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
            EndContext();
            BeginContext(402, 38, false);
#line 14 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\MyCompleteAppMvc\src\DevIO.App\Views\Fornecedores\_PartialDetail.cshtml"
   Write(this.FormataDocumento(Model.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(440, 48, true);
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
            EndContext();
            BeginContext(489, 41, false);
#line 17 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\MyCompleteAppMvc\src\DevIO.App\Views\Fornecedores\_PartialDetail.cshtml"
   Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(530, 49, true);
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
            EndContext();
            BeginContext(581, 28, false);
#line 20 "E:\_Dados_Maxdata\01_Desenvolvimento\_Aprendizado\MyCodes\CursoDesenvolvedorIO\aspnetcoremvc\MyCompleteAppMvc\src\DevIO.App\Views\Fornecedores\_PartialDetail.cshtml"
    Write(Model.Ativo ? "SIM" : "NÃO" );

#line default
#line hidden
            EndContext();
            BeginContext(610, 48, true);
            WriteLiteral("\r\n    </dd>\r\n</dl>\r\n\r\n<hr/>\r\n<h4>Endereço</h4>\r\n");
            EndContext();
            BeginContext(658, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d07073ab44986b5b061525fa32354ba356f417136827", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevIO.App.ViewModels.FornecedorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591