#pragma checksum "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60bfa9094565e6fd4b5b2d9e96757c9831e60faf"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor"
using Blazor.Contacts.Wasm.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contactdetails")]
    public partial class ContactDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor"
 if(contact == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Loading...</p>");
#nullable restore
#line 9 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor"
}
else{


#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor"
                     contact

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor"
                                             Save

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "card");
                __builder2.AddMarkupContent(7, "<h5 class=\"card-header\">Contact Details </h5>\n            ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "container");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-md-6 mb-3");
                __builder2.AddMarkupContent(14, "<label for>First Name</label>\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor"
                                                                      contact.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.FirstName = __value, contact.FirstName))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\n                        ");
                __builder2.AddMarkupContent(21, "<label for>Lasr Name</label>\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor"
                                                                      contact.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.LastName = __value, contact.LastName))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n                        ");
                __builder2.AddMarkupContent(28, "<label for>Phone</label>\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor"
                                                                      contact.Phone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.Phone = __value, contact.Phone))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.Phone));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\n                        ");
                __builder2.AddMarkupContent(35, "<label for>Address</label>\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor"
                                                                      contact.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.Address = __value, contact.Address))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.Address));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\n\n                    ");
                __builder2.AddMarkupContent(42, "<div class=\"row\"><div class=\"col-md-4 mb-3\"><input class=\"btn btn-success\" type=\"submit\" value=\"Save Contact\">\n                            <input class=\"btn btn-danger\" type=\"button\" value=\"Cancel\"></div></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 39 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/home/josue/Documentos/proyectos/Contactos/Blazor.Contacts.Wasm/Blazor.Contacts.Wasm.Client/Pages/ContactDetails.razor"
      
    public Contact contact;

        protected async override Task OnInitializedAsync()
        {
            contact = new Contact();
        }

        protected async Task Save()
        {
            await ContactService.SaveContact(contact);
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContactService ContactService { get; set; }
    }
}
#pragma warning restore 1591
