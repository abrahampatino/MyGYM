#pragma checksum "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\Emple\MisSocios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3210d6ce3ef361c3d72d4141d6f9f881715f09d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Empleado_Views_Emple_MisSocios), @"mvc.1.0.view", @"/Areas/Empleado/Views/Emple/MisSocios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Empleado/Views/Emple/MisSocios.cshtml", typeof(AspNetCore.Areas_Empleado_Views_Emple_MisSocios))]
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
#line 1 "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\_ViewImports.cshtml"
using Proyectov1;

#line default
#line hidden
#line 2 "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\_ViewImports.cshtml"
using Proyectov1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3210d6ce3ef361c3d72d4141d6f9f881715f09d0", @"/Areas/Empleado/Views/Emple/MisSocios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b435c54f70609462f602c995ac08e0525021069a", @"/Areas/Empleado/Views/_ViewImports.cshtml")]
    public class Areas_Empleado_Views_Emple_MisSocios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Proyectov1.Models.Persona>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\Emple\MisSocios.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 53, true);
            WriteLiteral("\r\n<h1>MIS SOCIOS</h1>\r\n\r\n<p>Total de Socios: <strong>");
            EndContext();
            BeginContext(144, 17, false);
#line 9 "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\Emple\MisSocios.cshtml"
                       Write(ViewBag.numsocios);

#line default
#line hidden
            EndContext();
            BeginContext(161, 281, true);
            WriteLiteral(@"</strong></p>
<table class=""table"">
    <thead>
        <tr>
            <th>Nombre(s)</th>
            <th>Apellidos</th>
            <th>Altura</th>
            <th>Peso</th>
            <th>Telefono</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 22 "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\Emple\MisSocios.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(474, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(523, 51, false);
#line 25 "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\Emple\MisSocios.cshtml"
           Write(String.Concat(item.PerNombre, " ", item.PerNombre2));

#line default
#line hidden
            EndContext();
            BeginContext(574, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(630, 52, false);
#line 28 "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\Emple\MisSocios.cshtml"
           Write(String.Concat(item.PerPaterno, " ", item.PerMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(682, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(738, 44, false);
#line 31 "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\Emple\MisSocios.cshtml"
           Write(Html.DisplayFor(modelItem => item.SocAltura));

#line default
#line hidden
            EndContext();
            BeginContext(782, 57, true);
            WriteLiteral(" m\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(840, 42, false);
#line 34 "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\Emple\MisSocios.cshtml"
           Write(Html.DisplayFor(modelItem => item.SocPeso));

#line default
#line hidden
            EndContext();
            BeginContext(882, 58, true);
            WriteLiteral(" kg\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(941, 46, false);
#line 37 "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\Emple\MisSocios.cshtml"
           Write(Html.DisplayFor(modelItem => item.SocTelefono));

#line default
#line hidden
            EndContext();
            BeginContext(987, 57, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1044, "\"", 1084, 2);
            WriteAttributeValue("", 1051, "/Emple/MisSocios/Edit/", 1051, 22, true);
#line 40 "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\Emple\MisSocios.cshtml"
WriteAttributeValue("", 1073, item.PerId, 1073, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1085, 33, true);
            WriteLiteral(">Editar</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1118, "\"", 1151, 2);
            WriteAttributeValue("", 1125, "/Emple/Routine/", 1125, 15, true);
#line 41 "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\Emple\MisSocios.cshtml"
WriteAttributeValue("", 1140, item.PerId, 1140, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1152, 51, true);
            WriteLiteral(">Ver Rutina</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 44 "D:\User\Desktop\Proyectov1\Areas\Empleado\Views\Emple\MisSocios.cshtml"
}

#line default
#line hidden
            BeginContext(1206, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Proyectov1.Models.Persona>> Html { get; private set; }
    }
}
#pragma warning restore 1591
