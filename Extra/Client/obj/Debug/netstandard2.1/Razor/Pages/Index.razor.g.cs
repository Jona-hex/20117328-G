#pragma checksum "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b9d00e86135cda6311de26645b8651eda40aadb"
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
#line 1 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\_Imports.razor"
using Extra.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\_Imports.razor"
using Extra.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "banner row");
            __builder.AddMarkupContent(5, "\r\n        <div class=\"banner-image\"></div>\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "overlay");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "nav");
            __builder.AddAttribute(10, "class", "navbar navbar-light bg-light");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "input-group input-group-lg");
            __builder.AddMarkupContent(14, "                   \r\n                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenTextBox>(15);
            __builder.AddAttribute(16, "placeholder", "Say My Name..");
            __builder.AddAttribute(17, "class", "form-control form-control-lg");
            __builder.AddAttribute(18, "value", 
#nullable restore
#line 15 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor"
                                                FiltersName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "valueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FiltersName = __value, FiltersName));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-primary btn-lg");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor"
                                                                     Buscar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "\r\n                        Search\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "suggestions");
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "container");
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 28 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor"
             if (CharacterList != null)
            { 
                foreach (CharacterDto character in CharacterList)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "card mb-3");
            __builder.AddAttribute(40, "style", "max-width: 540px;");
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "row g-0");
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-md-4");
            __builder.AddMarkupContent(47, "\r\n                                ");
            __builder.OpenElement(48, "img");
            __builder.AddAttribute(49, "src", 
#nullable restore
#line 35 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor"
                                           character.Img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "alt", "...");
            __builder.AddAttribute(51, "width", "200px");
            __builder.AddAttribute(52, "height", "200px");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col-md-8");
            __builder.AddMarkupContent(57, "\r\n                                ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "card-body");
            __builder.AddMarkupContent(60, "\r\n                                    ");
            __builder.OpenElement(61, "h5");
            __builder.AddAttribute(62, "class", "card-title text-center");
            __builder.AddContent(63, 
#nullable restore
#line 39 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor"
                                                                        character.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                    ");
            __builder.OpenElement(65, "li");
            __builder.AddMarkupContent(66, "\r\n                                        ");
            __builder.AddMarkupContent(67, "<small>Birthday :</small>\r\n                                        ");
            __builder.OpenElement(68, "span");
            __builder.AddContent(69, 
#nullable restore
#line 42 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor"
                                               character.Birthday

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                                    ");
            __builder.OpenElement(72, "li");
            __builder.AddMarkupContent(73, "\r\n                                        ");
            __builder.AddMarkupContent(74, "<small>Nickname:</small>\r\n                                        ");
            __builder.OpenElement(75, "span");
            __builder.AddContent(76, 
#nullable restore
#line 46 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor"
                                               character.Nickname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                                    ");
            __builder.OpenElement(79, "li");
            __builder.AddMarkupContent(80, "\r\n                                        ");
            __builder.AddMarkupContent(81, "<small>Actor/Actress :</small>\r\n                                        ");
            __builder.OpenElement(82, "span");
            __builder.AddContent(83, 
#nullable restore
#line 50 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor"
                                               character.Portrayed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                    ");
            __builder.OpenElement(86, "li");
            __builder.AddMarkupContent(87, "\r\n                                        ");
            __builder.AddMarkupContent(88, "<small>Status :</small>\r\n                                        ");
            __builder.OpenElement(89, "span");
            __builder.AddContent(90, 
#nullable restore
#line 54 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor"
                                               character.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                                    ");
            __builder.AddMarkupContent(93, "<li>\r\n                                        <small>Ocuppation :</small>\r\n                                        <span></span>\r\n                                    </li>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
#nullable restore
#line 64 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor"
                }      
            }
            else 
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "                ");
            __builder.AddMarkupContent(99, "<div class=\"col alert alert-danger text-center width-30%\">\r\n                 No characters Located\r\n                </div>\r\n");
#nullable restore
#line 71 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\Jonathan\ProgramacionWeb\programacion\extra\Client\Pages\Index.razor"
      
    private string FiltersName = string.Empty;

    private async Task Buscar()
    {  
        await LoadCharacters();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
