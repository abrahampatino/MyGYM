#pragma checksum "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "310737b7e56204c6af0a7205bcadc88ed7ee9eba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrador_Views_Socios_Index), @"mvc.1.0.view", @"/Areas/Administrador/Views/Socios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Administrador/Views/Socios/Index.cshtml", typeof(AspNetCore.Areas_Administrador_Views_Socios_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310737b7e56204c6af0a7205bcadc88ed7ee9eba", @"/Areas/Administrador/Views/Socios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b435c54f70609462f602c995ac08e0525021069a", @"/Areas/Administrador/Views/_ViewImports.cshtml")]
    public class Areas_Administrador_Views_Socios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Proyectov1.Models.Persona>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 455, true);
            WriteLiteral(@"
<h1>MIS SOCIOS</h1>


<a class=""btn btn-primary"" href=""/Admin/Socios/Create"">Nuevo Socio</a>

<table class=""table"">
    <thead>
        <tr>
            <th>Nombre(s)</th>
            <th>Apellidos</th>
            <th>Altura</th>
            <th>Peso</th>
            <th>Telefono</th>
            <th>Usuario</th>
            <th>Email</th>
            <th>Estatus</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 27 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(577, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(626, 51, false);
#line 30 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
           Write(String.Concat(item.PerNombre, " ", item.PerNombre2));

#line default
#line hidden
            EndContext();
            BeginContext(677, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(733, 52, false);
#line 33 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
           Write(String.Concat(item.PerPaterno, " ", item.PerMaterno));

#line default
#line hidden
            EndContext();
            BeginContext(785, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(841, 44, false);
#line 36 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SocAltura));

#line default
#line hidden
            EndContext();
            BeginContext(885, 57, true);
            WriteLiteral(" m\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(943, 42, false);
#line 39 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SocPeso));

#line default
#line hidden
            EndContext();
            BeginContext(985, 58, true);
            WriteLiteral(" kg\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1044, 46, false);
#line 42 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SocTelefono));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1146, 46, false);
#line 45 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Usu.UsuName));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1250, 46, false);
#line 49 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Usu.UsuCorr));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 51 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
             if (item.PerEstado.Value)
            {

#line default
#line hidden
            BeginContext(1372, 48, true);
            WriteLiteral("                <td class=\"active\">Activo</td>\r\n");
            EndContext();
#line 54 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1468, 52, true);
            WriteLiteral("                <td class=\"inactive\">Inactivo</td>\r\n");
            EndContext();
#line 58 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1535, 79, true);
            WriteLiteral("            <td class=\"td-buttons\">\r\n                <a class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1614, "\"", 1651, 2);
            WriteAttributeValue("", 1621, "/Admin/Socios/Edit/", 1621, 19, true);
#line 60 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
WriteAttributeValue("", 1640, item.PerId, 1640, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1652, 54, true);
            WriteLiteral(">Editar</a>\r\n                <a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1706, "\"", 1745, 2);
            WriteAttributeValue("", 1713, "/Admin/Socios/Delete/", 1713, 21, true);
#line 61 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
WriteAttributeValue("", 1734, item.PerId, 1734, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1746, 49, true);
            WriteLiteral(">Eliminar</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 64 "D:\User\Desktop\Proyectov1\Areas\Administrador\Views\Socios\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1798, 24, true);
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
