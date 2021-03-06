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
#line 1 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\_Imports.razor"
using Blazor.Contacts.Wasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\_Imports.razor"
using Blazor.Contacts.Wasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\Pages\ContactDetails.razor"
using Blazor.Contacts.Wasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\Pages\ContactDetails.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\Pages\ContactDetails.razor"
using System.ComponentModel.DataAnnotations;

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
#line 56 "C:\Users\JFlorez\Source\Repos\Contacts\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm.Client\Pages\ContactDetails.razor"
      
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
///TODO: Codigo mejorar
    bool success;
    string[] errors = { };
    MudTextField<string> pwField1;
    MudForm form;

    ///TODO: Agregar Eliminar/Deshabilitar
    ///TODO: Corregir Update

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContactService ContactService { get; set; }
    }
}
#pragma warning restore 1591
