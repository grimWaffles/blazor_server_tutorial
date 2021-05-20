#pragma checksum "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\Pages\Authors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a59bc798c164515fb9d5baf7d77e4286f236b650"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerTutorial.Pages
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
#nullable restore
#line 1 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\Pages\Authors.razor"
using BlazorServerTutorial.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors/{authorId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/authors")]
    public partial class Authors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Authors</h3>\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Is js really dead?</p>\r\n\r\n<br>\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-danger");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\Pages\Authors.razor"
                                         OnBtnClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Find out!");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, "The route parameter is ");
            __builder.AddContent(9, 
#nullable restore
#line 25 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\Pages\Authors.razor"
                           Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "D:\Work\Dev\C# DotNet\Web Apps\Blazor Tutorial\BlazorServerTutorial\Pages\Authors.razor"
       

    //To declare route parameters in the code file which we will later seperate
    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public int AuthorId { get; set; }

    void OnBtnClick()
    {
        //the way this nav manager works is that we call its navigate function that takes the desired route as a  parameter
        NavigationManager.NavigateTo("/authors/details");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService studentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
