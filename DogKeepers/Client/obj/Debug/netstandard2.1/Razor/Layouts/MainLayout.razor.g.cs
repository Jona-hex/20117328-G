#pragma checksum "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\Layouts\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e5d8ac43962f5de46238ebdfc1f17ead37be1ec"
// <auto-generated/>
#pragma warning disable 1591
namespace DogKeepers.Client.Layouts
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using DogKeepers.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using DogKeepers.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using DogKeepers.Client.Components.Loading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using DogKeepers.Client.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using DogKeepers.Client.Components.SectionPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\Layouts\MainLayout.razor"
using DogKeepers.Client.Components.NavMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\Layouts\MainLayout.razor"
using DogKeepers.Client.Components.TopBar;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "sidebar");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<DogKeepers.Client.Components.NavMenu.NavMenu>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenComponent<DogKeepers.Client.Components.TopBar.TopBar>(11);
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "content");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.AddContent(16, 
#nullable restore
#line 14 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\Layouts\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
