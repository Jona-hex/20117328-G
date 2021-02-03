#pragma checksum "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c51f117b663cb7cb04f6ba14b88fa49bff2b5ac"
// <auto-generated/>
#pragma warning disable 1591
namespace Extra.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\_Imports.razor"
using Extra.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\_Imports.razor"
using Extra.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\Pages\Index.razor"
using Extra.Shared.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""container-fluid"">
    <div class=""banner row"">
        <div class=""banner-image""></div>
        <div class=""overlay"">
            <nav class=""navbar navbar-light bg-light"">
                <div class=""input-group input-group-lg"">
                    <input type=""text"" placeholder=""Say My Name.."" class=""form-control form-control-lg"">
                    <button class=""btn btn-primary btn-lg"">
                        Search
                    </button>
                </div>
            </nav>
        </div>
    </div>
</div>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "suggestions");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 23 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\Pages\Index.razor"
             if (CharacterList != null)
            { 
                foreach (CharacterDto character in CharacterList)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card mb-3");
            __builder.AddAttribute(10, "style", "max-width: 540px;");
            __builder.AddMarkupContent(11, "\r\n                        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row g-0");
            __builder.AddMarkupContent(14, "\r\n                            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-md-4");
            __builder.AddMarkupContent(17, "\r\n                                ");
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "src", 
#nullable restore
#line 30 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\Pages\Index.razor"
                                           character.Img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "alt", "...");
            __builder.AddAttribute(21, "width", "100px");
            __builder.AddAttribute(22, "height", "100px");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-md-8");
            __builder.AddMarkupContent(27, "\r\n                                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "card-body");
            __builder.AddMarkupContent(30, "\r\n                                    ");
            __builder.OpenElement(31, "h5");
            __builder.AddAttribute(32, "class", "card-title text-center");
            __builder.AddContent(33, 
#nullable restore
#line 34 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\Pages\Index.razor"
                                                                        character.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                    ");
            __builder.OpenElement(35, "li");
            __builder.AddMarkupContent(36, "\r\n                                        ");
            __builder.AddMarkupContent(37, "<small>Birthday :</small>\r\n                                        ");
            __builder.OpenElement(38, "span");
            __builder.AddContent(39, 
#nullable restore
#line 37 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\Pages\Index.razor"
                                               character.Birthday

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                    ");
            __builder.OpenElement(42, "li");
            __builder.AddMarkupContent(43, "\r\n                                        ");
            __builder.AddMarkupContent(44, "<small>Nickname:</small>\r\n                                        ");
            __builder.OpenElement(45, "span");
            __builder.AddContent(46, 
#nullable restore
#line 41 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\Pages\Index.razor"
                                               character.Nickname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                                    ");
            __builder.OpenElement(49, "li");
            __builder.AddMarkupContent(50, "\r\n                                        ");
            __builder.AddMarkupContent(51, "<small>Actor/Actress :</small>\r\n                                        ");
            __builder.OpenElement(52, "span");
            __builder.AddContent(53, 
#nullable restore
#line 45 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\Pages\Index.razor"
                                               character.Portrayed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                    ");
            __builder.OpenElement(56, "li");
            __builder.AddMarkupContent(57, "\r\n                                        ");
            __builder.AddMarkupContent(58, "<small>Status :</small>\r\n                                        ");
            __builder.OpenElement(59, "span");
            __builder.AddContent(60, 
#nullable restore
#line 49 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\Pages\Index.razor"
                                               character.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                                    ");
            __builder.AddMarkupContent(63, "<li>\r\n                                        <small>Ocuppation :</small>\r\n                                        <span>ddddddd</span>\r\n                                    </li>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 59 "C:\Users\Jonathan\ProgramacionWeb\programacion\Extra\Client\Pages\Index.razor"
                }       
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
