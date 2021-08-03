using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Contacts.Wasm.Client
{
    public interface IContactService
    {
        Task SaveContact(Contact contact);
        Task DeleteContact(int id);
        Task<IEnumerable<Contact>> GetAll();
        Task<Contact> GetDetails(int id);
    }
    
}