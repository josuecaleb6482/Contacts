// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Contacts.Wasm.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 4 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor"
using Blazor.Contacts.Wasm.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contactdetails")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/contactdetails/{Id:int}")]
    public partial class ContactDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor"
      
    [Parameter]
    public int Id { get; set; }


    public Contact contact;

        protected async override Task OnInitializedAsync()
        {
            contact = new Contact();
            if(Id>0)
                contact = await ContactService.GetDetails(Id);
        }

        protected async Task Save()
        {
            await ContactService.SaveContact(contact);
            NavigationManager.NavigateTo("./contactlist");
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContactService ContactService { get; set; }
    }
}
#pragma warning restore 1591
