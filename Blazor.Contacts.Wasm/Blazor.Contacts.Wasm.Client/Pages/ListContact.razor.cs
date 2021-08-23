using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.Contacts.Wasm.Client.Shared.Dialog;
using Microsoft.AspNetCore.Components;

namespace Blazor.Contacts.Wasm.Client.Pages
{
    public partial class ListContact : ComponentBase
    {
        public IEnumerable<Contact> contacts;
        public string Message = "";
        public Severity severity = Severity.Normal;
        public bool _loading = true;

        protected override async Task OnInitializedAsync()
        {
            contacts = await ContactService.GetAll();
            _loading = false;
        }

        public async void Edit(int id)
        {
            var parameters = new DialogParameters();
            parameters.Add("id", id);

            var dialog = DialogServices.Show<DialogForm>("Edit Contact", parameters);
            var result = await dialog.Result;
            if (!result.Cancelled)
            {

                contacts = await ContactService.GetAll();
                StateHasChanged();
                Snackbar.Add("Edit Success", Severity.Success);
            }
        }

        public async void Delete(int id)
        {
            bool? result = await DialogServices.ShowMessageBox(
                "Delete Contact",
                "Are you sure to want delete?",
                yesText: "Delete?",
                cancelText: "Cancel"
                );
            if (result == null)
            {
                Message = "Cancelado";
                severity = Severity.Info;
            }
            else
            {
                try
                {
                    _loading = true;
                    await ContactService.DeleteContact(id);
                    contacts = await ContactService.GetAll();
                    Snackbar.Add("Delete Success", Severity.Success);
                }
                catch (Exception ex)
                {
                    Message = "Error al borrar";
                    severity = Severity.Error;
                }
            }
            _loading = false;
            StateHasChanged();
        }

        public async void CreateNew()
        {
            var dialog = DialogServices.Show<DialogForm>("Create Contact");
            var result = await dialog.Result;

            if (!result.Cancelled)
            {
                contacts = await ContactService.GetAll();
                StateHasChanged();
                Snackbar.Add("Create Success", Severity.Success);
            }

        }
    }
}
