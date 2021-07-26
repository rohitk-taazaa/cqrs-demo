using Demo.Core.Contracts;
using Demo.Core.Data;
using Demo.Core.Domain;
using Demo.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Services
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person> _personRepository;

        public PersonService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }
        public async Task<bool> AddNewPerson(PersonEditModel personModel)
        {
            if (personModel == null)
                throw new InvalidOperationException("Invalid person");
            Person person = new();
            person.FName = personModel.FName;
            person.LName = personModel.LName;
            person.IsNew = true;
            await _personRepository.SaveChangesAsync(person);
            return true;
        }

        public async Task<bool> DeletePerson(Guid Id)
        {
            Person person = await _personRepository.GetByIdAsync(Id);
            if (person != null)
                await _personRepository.DeleteAsync(person);
            return true;
        }

        public IEnumerable<PersonViewModel> GetAllPerson()
        {
            var model = _personRepository.Table.Select(x =>
               new PersonViewModel { FName = x.FName, LName = x.LName, Id = x.Id }
            ).ToList();
            return model;
        }

        public async Task<PersonViewModel> GetPersonById(Guid personId)
        {
            Person person = await _personRepository.GetByIdAsync(personId);
            return new PersonViewModel
            {
                Id = person.Id,
                FName = person.FName,
                LName = person.LName
            };
        }
    }
}
