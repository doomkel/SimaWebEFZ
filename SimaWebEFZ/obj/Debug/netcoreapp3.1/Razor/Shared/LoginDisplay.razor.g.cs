#pragma checksum "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba215ff64565d0b66dbf6fa4840a9ea569e4db57"
// <auto-generated/>
#pragma warning disable 1591
namespace SimaWebEFZ.Shared
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
    public partial class LoginDisplay : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        Hello, ");
#nullable restore
#line 3 "C:\Users\dan\Source\Repos\doomkel\SimaWebEFZ\SimaWebEFZ\Shared\LoginDisplay.razor"
__builder2.AddContent(3, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(4, "!\r\n        ");
                __builder2.AddMarkupContent(5, "<a href=\"AzureAD/Account/SignOut\">Log out</a>\r\n    ");
            }
            ));
            __builder.AddAttribute(6, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddMarkupContent(8, "<a href=\"AzureAD/Account/SignIn\">Log in</a>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
