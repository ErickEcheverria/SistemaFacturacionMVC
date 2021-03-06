#pragma checksum "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6f90621b93e4ea78f0d6aaa20cb496b02e0cd5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reportes_ReporteFacturas), @"mvc.1.0.view", @"/Views/Reportes/ReporteFacturas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6f90621b93e4ea78f0d6aaa20cb496b02e0cd5f", @"/Views/Reportes/ReporteFacturas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2b6071b9396d0011302dcd8ac330b2263574bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Reportes_ReporteFacturas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaFacturacionMVC.Models.P_REPORTE_FACTURAS>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reportes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
  
    ViewData["Title"] = "Reporte de Facturas";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
     if (TempData["mensaje"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n            ");
#nullable restore
#line 12 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
       Write(TempData["mensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                <span aria-hidden=\"true\">&times;</span>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-sm-6"">
            <h3>Listado de ventas</h3>
        </div>
        <div class=""col-sm-7"">
            <button id=""listaFacturas"" onclick=""seleccionarFactura();"" class=""form-control"">Limpiar busqueda</button>
            <hr />
            <input type=""date"" onchange=""analizarFechas();"" class=""form-control"" id=""fechaPrimero"">
            <hr />
            <input type=""date"" onchange=""analizarFechas();"" class=""form-control"" id=""fechaSegundo"">
        </div>
    </div>
    <hr />
    <div class=""row"">
");
#nullable restore
#line 33 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-bordered table-striped\">\r\n                <thead>\r\n                    <tr>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
                       Write(Html.DisplayNameFor(m => m.Dia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
                       Write(Html.DisplayNameFor(m => m.cantidadFacturas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
                       Write(Html.DisplayNameFor(m => m.montoFacturado));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
                       Write(Html.DisplayNameFor(m => m.cantidadProductos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 48 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
                           Write(item.Dia.ToString("dd-MMMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 49 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
                           Write(item.cantidadFacturas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 50 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
                           Write(item.montoFacturado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
                           Write(item.cantidadProductos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 56 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Actualmente no existe ninguna factura</p>\r\n");
#nullable restore
#line 60 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <hr />\r\n    <center>\r\n        <div class=\"col-sm-10\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6f90621b93e4ea78f0d6aaa20cb496b02e0cd5f11282", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </center>
</div>

<script>
    function analizarFechas() {
        var fecha1 = document.getElementById('fechaPrimero');
        var fecha2 = document.getElementById('fechaSegundo');

        fechaPrimero = fecha1.value;
        fechaSegundo = fecha2.value;

        if (fechaPrimero == """" || fechaSegundo == """") {
            alert(""NOTA: Ambas fechas son Obligatorias"");
        } else {
            seleccionarFactura();
        }

    }

    function seleccionarFactura() {
        var fecha1 = document.getElementById('fechaPrimero');
        var fecha2 = document.getElementById('fechaSegundo');

        fechaPrimero = fecha1.value;
        fechaSegundo = fecha2.value;

        if (fechaPrimero == """" || fechaSegundo == """") {
            var url = """);
#nullable restore
#line 94 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
                  Write(Url.Action("ReporteFacturas", "Reportes", new { todos = "param-id" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n            url = url.replace(\"param-id\", 0);\r\n            $(\"#result\").load(url);\r\n\r\n            window.location.href = url;\r\n\r\n            return;\r\n        }\r\n\r\n        if (fechaPrimero != \"\" && fechaSegundo != \"\") {\r\n            var url = \"");
#nullable restore
#line 104 "C:\Users\Erick Echeverría\source\repos\SistemaFacturacionMVC\SistemaFacturacionMVC\Views\Reportes\ReporteFacturas.cshtml"
                  Write(Url.Action("ReporteFacturas", "Reportes", new { fechaInicio = "param-fechaInicio", fechaFinal = "param-fechaFinal" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
            url = url.replace(""param-fechaInicio"", fechaPrimero).replace(""param-fechaFinal"", fechaSegundo);
            $(""#result"").load(url);

            url = url.replace(""amp;"", """");
            url = url.replace(""amp;"", """");

            window.location.href = url;

            return;
        }

    }

</script>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6f90621b93e4ea78f0d6aaa20cb496b02e0cd5f15023", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaFacturacionMVC.Models.P_REPORTE_FACTURAS>> Html { get; private set; }
    }
}
#pragma warning restore 1591
