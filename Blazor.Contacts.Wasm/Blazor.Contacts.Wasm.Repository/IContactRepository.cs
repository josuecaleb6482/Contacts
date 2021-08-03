using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Contacts.Wasm.Repository
{
    public interface IContactRepository
    {
        Task<bool> InsertContact(Contact contact);
        Task<bool> UpdateContact(Contact contact);
        Task DeleteContact(int id);
        Task<IEnumerable<Contact>> GetAll();
        Task<Contact> GetContact(int id);
    }
}
