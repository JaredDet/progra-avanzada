#pragma checksum "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cb9f025b2a45d2e7560500c2d329381659d0695"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorserver01.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rabbits_and_carrots")]
    public partial class RabbitsAndCarrots : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Rabbits and Carrots</h1>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n<hr>\r\n\r\n");
#nullable restore
#line 8 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor"
  
    // only the first time (initial pattern)
    if (currentCount == 0) {
        u = new Data.Rabbit(3, 3, e);
        e.insert(3, 3, u);
        u = new Data.Rabbit(3, 4, e);
        e.insert(3, 4, u);
        u = new Data.Rabbit(3, 5, e);
        e.insert(3, 5, u);
        u = new Data.Rabbit(2, 5, e);
        e.insert(2, 5, u);
        u = new Data.Rabbit(1, 4, e);
        e.insert(1, 4, u);

        u = new Data.Carrot(11, 14, e);
        e.insert(11, 14, u);
        u = new Data.Carrot(12, 15, e);
        e.insert(12, 15, u);
        u = new Data.Carrot(13, 14, e);
        e.insert(13, 14, u);
        u = new Data.Carrot(0, 0, e);
        e.insert(0, 0, u);

        // Líneas cambiadas
        int count1 = e.neighbors(1, 1).Count();
        int count2 = e.neighbors(1, 5).Count();
        int count3 = e.neighbors(2, 3).Count();
        Console.WriteLine("Neighbors");
        Console.WriteLine(count1);
        Console.WriteLine(count2);
        Console.WriteLine(count3);
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "environment");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 43 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor"
     for (var i = 0; i < @e.total_of_rows(); i++) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 45 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor"
             for (var j = 0; j < @e.total_of_cols(); j++) {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor"
                 if (e.biounit(i, j) != null) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                    ");
            __builder.OpenElement(13, "td");
            __builder.AddAttribute(14, "class", "cell");
            __builder.AddAttribute(15, "style", "background-color:" + (
#nullable restore
#line 47 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor"
                                                              e.biounit(i, j).myColor()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 48 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor"
                }
                else {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "                    <td class=\"cell dead\"></td>\r\n");
#nullable restore
#line 51 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 54 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n<hr>\r\n");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Next");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Taller 10/blazorserver01/Pages/RabbitsAndCarrots.razor"
       
    private int currentCount = 0;
    private Data.Environment e = new Data.Environment(40, 40);
    private Data.BioUnit u;
    private void IncrementCount()
    {
        currentCount++;
        e.next_Rabbit_Carrot_Step();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
