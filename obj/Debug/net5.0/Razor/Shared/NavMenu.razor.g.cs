#pragma checksum "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6072f20c8ceef08e42f0f6928fc5b175e668c1b3"
// <auto-generated/>
#pragma warning disable 1591
namespace Proyecti_Cafeteria.ClientesBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Proyecti_Cafeteria.ClientesBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using Proyecti_Cafeteria.ClientesBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudNavLink>(2);
                __builder2.AddAttribute(3, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\NavMenu.razor"
                       Icons.Material.Filled.Flatware

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 2 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\NavMenu.razor"
                                                                   Color.Inherit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Href", "/");
                __builder2.AddAttribute(6, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 2 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\NavMenu.razor"
                                                                                                  NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(8, "INICIO");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(10);
                __builder2.AddAttribute(11, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\NavMenu.razor"
                       Icons.Material.Filled.Coffee

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Href", "/counter");
                __builder2.AddAttribute(13, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 3 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\NavMenu.razor"
                                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 3 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\NavMenu.razor"
                                                                                                       NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(16, "PRODUCTO");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(18);
                __builder2.AddAttribute(19, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\NavMenu.razor"
                       Icons.Material.Filled.LocalBar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "Href", "/counter");
                __builder2.AddAttribute(21, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 4 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\NavMenu.razor"
                                                                                   Color.Inherit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 4 "C:\Users\Machine\Desktop\ProyectoCafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Proyecti Cafeteria.ClientesBlazor\Shared\NavMenu.razor"
                                                                                                         NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(24, "CATEGORIA");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591