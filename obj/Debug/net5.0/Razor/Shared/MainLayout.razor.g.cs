#pragma checksum "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20ff55b4a73574ba35df3cd3acc76072888c69a4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerTutorial.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\_Imports.razor"
using BlazorServerTutorial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\_Imports.razor"
using BlazorServerTutorial.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\_Imports.razor"
using BlazorServerTutorial.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\_Imports.razor"
using BlazorServerTutorial.Data.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-ggr5r4i2qt");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-ggr5r4i2qt");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<BlazorServerTutorial.Shared.NavMenu>(8);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "main");
            __builder.AddAttribute(12, "b-ggr5r4i2qt");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "top-row px-4");
            __builder.AddAttribute(15, "b-ggr5r4i2qt");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(16);
            __builder.AddAttribute(17, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(18, "a");
                __builder2.AddAttribute(19, "href", "/login");
                __builder2.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\Shared\MainLayout.razor"
                                               Logout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "b-ggr5r4i2qt");
                __builder2.AddContent(22, "Logout");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(23, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(24, "a");
                __builder2.AddAttribute(25, "href", "/login");
                __builder2.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\Shared\MainLayout.razor"
                                               Login

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "b-ggr5r4i2qt");
                __builder2.AddContent(28, "Login");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "content px-4");
            __builder.AddAttribute(32, "b-ggr5r4i2qt");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(33);
            __builder.AddAttribute(34, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddContent(35, 
#nullable restore
#line 28 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\Shared\MainLayout.razor"
                    Body

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.AddAttribute(36, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(37, "<h4 b-ggr5r4i2qt>Nope.</h4>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\Shared\MainLayout.razor"
      
    public void Login()
    {
        NavigationManager.NavigateTo("/");
    }
    public void Logout()
    {
        ((CustomAuthenticationStateProvider)Auth).MarkUserUnAuthorized();
        NavigationManager.NavigateTo("/login");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider Auth { get; set; }
    }
}
#pragma warning restore 1591
