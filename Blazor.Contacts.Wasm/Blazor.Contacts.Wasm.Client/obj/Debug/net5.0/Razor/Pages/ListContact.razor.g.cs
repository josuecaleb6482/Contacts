#pragma checksum "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ListContact.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1df800f0888832b1df576a1068af1f2055b7ab8d"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Contacts.Wasm.Client.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/_Imports.razor"
using Blazor.Contacts.Wasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/_Imports.razor"
using Blazor.Contacts.Wasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ListContact.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contactlist")]
    public partial class ListContact : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ListContact.razor"
 if(contacts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Loading...</p>");
#nullable restore
#line 11 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ListContact.razor"
}
else{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-hover");
            __builder.AddMarkupContent(3, "<thead><tr><th>Name</th>\n                <th>Phone</th>\n                <th>Address</th>\n                <td></td></tr></thead>\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 24 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ListContact.razor"
             foreach(var contact in contacts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 27 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ListContact.razor"
                         contact.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 28 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ListContact.razor"
                         contact.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 29 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ListContact.razor"
                         contact.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "td");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "btn btn-primary");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ListContact.razor"
                                                                () => Edit(contact.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                        ");
            __builder.AddMarkupContent(21, "<div class=\"btn btn-danger\">Borrar</div>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ListContact.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ListContact.razor"
    
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ListContact.razor"
      
    public IEnumerable<Contact> contacts;

    protected async override Task OnInitializedAsync()
    {
        contacts = await ContactService.GetAll();
    }
    
    public void Edit(int id)
    {
        NavigationManager.NavigateTo($"./contactdetails/{id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContactService ContactService { get; set; }
    }
}
#pragma warning restore 1591
