using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Blazor.Contacts.Wasm.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDbConnection _dbConnection;

        public ContactRepository(IDbConnection dbConnection)
        {
            this._dbConnection = dbConnection;
        }

        public Task DeleteContact(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Contact>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Contact> GetContact()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> InsertContact(Contact contact)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateContact(Contact contact)
        {
            throw new System.NotImplementedException();
        }
    }
}
