using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.Contacts.Wasm.Repository;
using Microsoft.AspNetCore.Mvc;
namespace Blazor.Contacts.Wasm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;

        public ContactsController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Contact contact){
            if(contact==null)
                return BadRequest();
            
            if(string.IsNullOrEmpty(contact.FirstName))
                ModelState.AddModelError("FirstName", "First name can't be empty");
            
            if(string.IsNullOrEmpty(contact.LastName))
                ModelState.AddModelError("LastName", "Lasr name can't be empty");

            if(!ModelState.IsValid)
                return BadRequest();
            
            await _contactRepository.InsertContact(contact);

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Contact contact){
            if(contact==null)
                return BadRequest();
            
            if(string.IsNullOrEmpty(contact.FirstName))
                ModelState.AddModelError("FirstName", "First name can't be empty");
            
            if(string.IsNullOrEmpty(contact.LastName))
                ModelState.AddModelError("LastName", "Lasr name can't be empty");

            if(!ModelState.IsValid)
                return BadRequest();
            
            await _contactRepository.UpdateContact(contact);

            return NoContent();
        }

        [HttpGet]
        public async Task<IEnumerable<Contact>> Get()
        {
            return await _contactRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Contact> GetDetails(int id)
        {
            return await _contactRepository.GetContact(id);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _contactRepository.DeleteContact(id);
        }

    }
}
