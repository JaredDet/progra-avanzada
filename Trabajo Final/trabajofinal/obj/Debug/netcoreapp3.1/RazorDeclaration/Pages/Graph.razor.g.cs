#pragma checksum "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/Pages/Graph.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d5bbbdf696060538bd11e7bae4b73b25ca8a62c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace trabajofinal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using trabajofinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/_Imports.razor"
using trabajofinal.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/evidence-graph")]
    public partial class Graph : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "/mnt/Archivos/Proyectos/HTML CSS JS/programacion-avanzada/Trabajo Final/trabajofinal/Pages/Graph.razor"
       
    // Data obtained from the textarea
    private static string input = "{(\"Etiqueta_1\",\"D\",20), (\"X\",\"C\",0), (\"X\",\"Ciudad\",10),(\"X\",\"A\",13), (\"Otra_etiqueta\",\"D\",7), (\"Y\",\"Etiqueta_2\",6), (\"Z\",\"A\",2), (\"Z\",\"País\",13), (\"W\",\"C\",15), (\"W\",\"D\",7)}";
    private static string colors = "\"yellow\", \"green\", \"red\", \"blue\", \"magenta\", \"cyan\", \"black\", \"brown\", \"orange\", \"violet\", \"gray\"";
    private static string size = "800px, 800px";
    private Data.EvidenceGraph e;

    private void Render()
    {
        e = new Data.EvidenceGraph(input, colors);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
