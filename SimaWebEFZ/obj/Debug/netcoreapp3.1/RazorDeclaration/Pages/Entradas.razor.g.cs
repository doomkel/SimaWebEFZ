// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
