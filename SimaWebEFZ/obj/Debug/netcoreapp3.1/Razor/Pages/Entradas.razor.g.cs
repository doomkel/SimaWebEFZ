#pragma checksum "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94646c50c168d730d52b38120a57a8a6fc7360b9"
// <auto-generated/>
#pragma warning disable 1591
namespace SimaWebEFZ.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\_Imports.razor"
using SimaWebEFZ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\_Imports.razor"
using SimaWebEFZ.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/entradas")]
    public partial class Entradas : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Entradas</h3>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
 if(entradas is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Cargando...</p>\r\n");
#nullable restore
#line 13 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
}
else
{
    //filtro reporte

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group row align-content-start");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<label for=\"Inicial\" class=\"col-2 col-form-label\">\r\n            Fecha Inicial\r\n        </label>\r\n        ");
            __builder.AddMarkupContent(8, "<div class=\"col-3\">\r\n            <input type=\"date\" class=\"form-control valid\" value=\"2022-12-01\">\r\n        </div>\r\n        ");
            __builder.AddMarkupContent(9, "<label for=\"Final\" class=\"col-2 col-form-label\">\r\n            Fecha Final\r\n        </label>\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-3");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "date");
            __builder.AddAttribute(15, "class", "form-control valid");
            __builder.AddAttribute(16, "value", 
#nullable restore
#line 28 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
                                                                  fecFinal.ToString("yyyy-MM-dd")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddMarkupContent(19, "<div class=\"col-1\">\r\n            <button type=\"button\" class=\"btn btn-primary\">Generar</button>\r\n        </div>\r\n        ");
            __builder.AddMarkupContent(20, "<div class=\"col-1\">\r\n            <button type=\"button\" class=\"btn btn-info\">\r\n                <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-gear\" viewBox=\"0 0 16 16\">\r\n                    <path d=\"M8 4.754a3.246 3.246 0 1 0 0 6.492 3.246 3.246 0 0 0 0-6.492zM5.754 8a2.246 2.246 0 1 1 4.492 0 2.246 2.246 0 0 1-4.492 0z\"></path>\r\n                    <path d=\"M9.796 1.343c-.527-1.79-3.065-1.79-3.592 0l-.094.319a.873.873 0 0 1-1.255.52l-.292-.16c-1.64-.892-3.433.902-2.54 2.541l.159.292a.873.873 0 0 1-.52 1.255l-.319.094c-1.79.527-1.79 3.065 0 3.592l.319.094a.873.873 0 0 1 .52 1.255l-.16.292c-.892 1.64.901 3.434 2.541 2.54l.292-.159a.873.873 0 0 1 1.255.52l.094.319c.527 1.79 3.065 1.79 3.592 0l.094-.319a.873.873 0 0 1 1.255-.52l.292.16c1.64.893 3.434-.902 2.54-2.541l-.159-.292a.873.873 0 0 1 .52-1.255l.319-.094c1.79-.527 1.79-3.065 0-3.592l-.319-.094a.873.873 0 0 1-.52-1.255l.16-.292c.893-1.64-.902-3.433-2.541-2.54l-.292.159a.873.873 0 0 1-1.255-.52l-.094-.319zm-2.633.283c.246-.835 1.428-.835 1.674 0l.094.319a1.873 1.873 0 0 0 2.693 1.115l.291-.16c.764-.415 1.6.42 1.184 1.185l-.159.292a1.873 1.873 0 0 0 1.116 2.692l.318.094c.835.246.835 1.428 0 1.674l-.319.094a1.873 1.873 0 0 0-1.115 2.693l.16.291c.415.764-.42 1.6-1.185 1.184l-.291-.159a1.873 1.873 0 0 0-2.693 1.116l-.094.318c-.246.835-1.428.835-1.674 0l-.094-.319a1.873 1.873 0 0 0-2.692-1.115l-.292.16c-.764.415-1.6-.42-1.184-1.185l.159-.291A1.873 1.873 0 0 0 1.945 8.93l-.319-.094c-.835-.246-.835-1.428 0-1.674l.319-.094A1.873 1.873 0 0 0 3.06 4.377l-.16-.292c-.415-.764.42-1.6 1.185-1.184l.292.159a1.873 1.873 0 0 0 2.692-1.115l.094-.319z\"></path>\r\n                </svg>\r\n            </button>\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 42 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"

    //tabla

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "    ");
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "table table-striped");
            __builder.AddMarkupContent(25, "\r\n         ");
            __builder.AddMarkupContent(26, @"<thead>
             <tr>
                <th>Fecha</th>
                <th>Folio</th>
                <th>Recibe</th>
                <th>Nombre</th>
                <th>Proveedor</th>
                <th>Factura</th>
                <th>Sku</th>
                <th>Codigo</th>
                <th>Descripcion</th>
                <th>Piezas</th>
                <th>Costo Factura</th>
                <th>Costo Pesos</th>
             </tr>
         </thead>
         ");
            __builder.OpenElement(27, "tbody");
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 62 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
              foreach (var item in entradas)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "                ");
            __builder.OpenElement(30, "tr");
            __builder.AddAttribute(31, "class", true);
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
#nullable restore
#line 65 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
__builder.AddContent(34, item.fecha.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
#nullable restore
#line 66 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
__builder.AddContent(37, item.folio);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
#nullable restore
#line 67 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
__builder.AddContent(40, item.recibe);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
#nullable restore
#line 68 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
__builder.AddContent(43, item.alm_recibe);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "td");
#nullable restore
#line 69 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
__builder.AddContent(46, item.proveedor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "td");
#nullable restore
#line 70 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
__builder.AddContent(49, item.factura);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "td");
#nullable restore
#line 71 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
__builder.AddContent(52, item.sku);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenElement(54, "td");
#nullable restore
#line 72 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
__builder.AddContent(55, item.cod_componente);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "td");
#nullable restore
#line 73 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
__builder.AddContent(58, item.des_componente);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "td");
#nullable restore
#line 74 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
__builder.AddContent(61, item.pzas);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.OpenElement(63, "td");
#nullable restore
#line 75 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
__builder.AddContent(64, item.costo_fac);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "td");
#nullable restore
#line 76 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
__builder.AddContent(67, item.costo_pesos);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 78 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 81 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Pages\Entradas.razor"
       
    private List<EntradasModel> entradas;

    private DateTime fecFinal = DateTime.Today;

    protected override async Task OnInitializedAsync()
    {        
        entradas = await _db.GetEntradas();
    }

    
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEntradasData _db { get; set; }
    }
}
#pragma warning restore 1591
