using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;

namespace Blazor.Contacts.Wasm.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDbConnection _dbConnection;

        public ContactRepository(IDbConnection dbConnection)
        {
            this._dbConnection = dbConnection;
        }

        public async Task DeleteContact(int id)
        {
            var sql = @"DELETE FROM Contacts
                            WHERE Id = @Id";

            var result = await _dbConnection.ExecuteAsync(sql, new {Id = id});
        }

        public async Task<IEnumerable<Contact>> GetAll()
        {
            var sql = @"SELECT Id
                               ,FirstName
                               ,LastName
                               ,Phone
                               ,Address
                            FROM Contacts";

            return await _dbConnection.QueryAsync<Contact>(sql, new {});
        }

        public async Task<Contact> GetContact(int id)
        {
            var sql = @"SELECT Id
                               ,FirstName
                               ,LastName
                               ,Phone
                               ,Address
                            FROM Contacts
                            WHERE Id = @Id";

            return await _dbConnection.QueryFirstOrDefaultAsync<Contact>(
                                        sql, new {
                                                    Id = id
                                                }
                                        );

        }

        public async Task<bool> InsertContact(Contact contact)
        {
            try
            {
                var sql = @"INSERT INTO Contacts (FirstName, LastName, Phone, Address)
                            VALUES(@FirstName, @LastName, @Phone, @Address)";
                var result = await _dbConnection.ExecuteAsync(sql, new {
                    contact.FirstName,
                    contact.LastName,
                    contact.Phone,
                    contact.Address
                });

                return result > 0;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateContact(Contact contact)
        {
            try
            {
                var sql = @"UPDATE Contacts 
                                SET(FirstName=@FirstName, 
                                LastName=@LastName, 
                                Phone=@Phone, 
                                Address=@Address)";

                var result = await _dbConnection.ExecuteAsync(sql, new {
                    contact.FirstName,
                    contact.LastName,
                    contact.Phone,
                    contact.Address
                });

                return result > 0;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
