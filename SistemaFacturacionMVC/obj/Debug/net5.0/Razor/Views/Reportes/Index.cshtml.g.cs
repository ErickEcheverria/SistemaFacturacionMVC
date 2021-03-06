#pragma checksum "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7fee69f9a881e6346de90446906bb0d4dcf4adc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reportes_Index), @"mvc.1.0.view", @"/Views/Reportes/Index.cshtml")]
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
#line 1 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\_ViewImports.cshtml"
using SistemaFacturacionMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\_ViewImports.cshtml"
using SistemaFacturacionMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7fee69f9a881e6346de90446906bb0d4dcf4adc", @"/Views/Reportes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2b6071b9396d0011302dcd8ac330b2263574bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Reportes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\Index.cshtml"
  
    ViewData["Title"] = "Detalle de la factura";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\Index.cshtml"
     if (TempData["mensaje"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n            ");
#nullable restore
#line 11 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\Index.cshtml"
       Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"card\">\r\n        <h5 class=\"card-header\">Ventas por productos</h5>\r\n        <div class=\"card-body\" align=\"center\">\r\n            <h5 class=\"card-title\">Ventas por productos</h5>\r\n            ");
#nullable restore
#line 22 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\Index.cshtml"
       Write(Html.ActionLink("Visualizar", "ReporteVentasProducto", new { idProducto = 0, fechaInicio = "", fechaFinal = "" }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <hr />\r\n    <div class=\"card\">\r\n        <h5 class=\"card-header\">Ventas por Clientes</h5>\r\n        <div class=\"card-body\" align=\"center\">\r\n            <h5 class=\"card-title\">Ventas de Clientes</h5>\r\n            ");
#nullable restore
#line 30 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\Index.cshtml"
       Write(Html.ActionLink("Visualizar", "ReporteVentasCliente", new { idCliente = 0, fechaInicio = "", fechaFinal = "" }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <hr />\r\n    <div class=\"card\">\r\n        <h5 class=\"card-header\">Reporte de Facturas</h5>\r\n        <div class=\"card-body\" align=\"center\">\r\n            <h5 class=\"card-title\">Reporte de Facturas</h5>\r\n            ");
#nullable restore
#line 38 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\Index.cshtml"
       Write(Html.ActionLink("Visualizar", "ReporteFacturas", new { todos = 0, fechaInicio = "", fechaFinal = "" }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n");
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
