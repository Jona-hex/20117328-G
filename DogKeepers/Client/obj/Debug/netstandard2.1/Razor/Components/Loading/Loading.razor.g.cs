#pragma checksum "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\Components\Loading\Loading.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "004348ec6c0dfaa54a403bbcf55f221b0e0e3a52"
// <auto-generated/>
#pragma warning disable 1591
namespace DogKeepers.Client.Components.Loading
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
    public partial class Loading : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\Components\Loading\Loading.razor"
 if(IsLoading)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, @"<div class=""loading row"">
        <div class=""col-12 text-center"">
            <div>
                <img src=""images\GoldenRetriever.svg"">
            </div>
            <h5>
                Ladrando..
            </h5>
        </div>
    </div>
");
#nullable restore
#line 13 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\Components\Loading\Loading.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, 
#nullable restore
#line 16 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\Components\Loading\Loading.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 16 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\Components\Loading\Loading.razor"
                 
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Jonathan\ProgramacionWeb\programacion\dogkeepers\Client\Components\Loading\Loading.razor"
 
    [Parameter] public bool IsLoading { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
