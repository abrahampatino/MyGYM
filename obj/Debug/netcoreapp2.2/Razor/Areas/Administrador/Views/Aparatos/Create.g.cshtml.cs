#pragma checksum "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Aparatos\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46e9c1a6f56b559d36a4a212559a2833540afede"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrador_Views_Aparatos_Create), @"mvc.1.0.view", @"/Areas/Administrador/Views/Aparatos/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Administrador/Views/Aparatos/Create.cshtml", typeof(AspNetCore.Areas_Administrador_Views_Aparatos_Create))]
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
#line 1 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\_ViewImports.cshtml"
using Proyectov1;

#line default
#line hidden
#line 2 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\_ViewImports.cshtml"
using Proyectov1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46e9c1a6f56b559d36a4a212559a2833540afede", @"/Areas/Administrador/Views/Aparatos/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b435c54f70609462f602c995ac08e0525021069a", @"/Areas/Administrador/Views/_ViewImports.cshtml")]
    public class Areas_Administrador_Views_Aparatos_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Proyectov1.Models.Aparato>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Aparatos/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Aparatos\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(78, 107, true);
            WriteLiteral("\r\n<h1>Agregar Nuevo Tipo de Aparato</h1>\r\n\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(185, 1356, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46e9c1a6f56b559d36a4a212559a2833540afede4529", async() => {
                BeginContext(237, 1297, true);
                WriteLiteral(@"
            <div class=""form-row"">
                <div class=""form-group  col-md-8"">
                    <label class=""control-label"" for=""ApaNombre"">Tipo de Aparato</label>

                    <input class=""form-control"" type=""text"" id=""ApaNombre"" name=""ApaNombre"" minlength=""5"" maxlength=""20"" placeholder=""Caminadora"" required />
                    <span class=""text-danger field-validation-valid"" data-valmsg-for=""ApaNombre"" data-valmsg-replace=""true""></span>
                </div>
                <div class=""form-group  col-md-8"">
                    <label class=""control-label"" for=""ApaDescripcion"">Descripci&oacute;n</label>
                    <input class=""form-control"" type=""text"" id=""ApaDescripcion"" name=""ApaDescripcion""  maxlength=""30"" minlength=""0"" placeholder=""Aparato de pierna""/>
                    <span class=""text-danger field-validation-valid"" data-valmsg-for=""ApaDescripcion"" data-valmsg-replace=""true""></span>
                </div>
            </div>
            <div>
        ");
                WriteLiteral(@"        <div class=""form-group-buttons"">
                    <a class=""btn btn-success"" href=""/Admin/Aparatos"">Regresar a Listado</a>
                    <input type=""submit"" value=""Agregar"" class=""btn btn-primary"" />
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1541, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1583, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 37 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Aparatos\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proyectov1.Models.Aparato> Html { get; private set; }
    }
}
#pragma warning restore 1591
