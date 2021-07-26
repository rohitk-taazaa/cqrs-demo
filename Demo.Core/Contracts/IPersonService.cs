using Demo.Core.Domain;
using Demo.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Contracts
{
    public interface IPersonService
    {
        Task<bool> AddNewPerson(PersonEditModel personModel);
        Task<bool> DeletePerson(Guid Id);
        IEnumerable<PersonViewModel> GetAllPerson();
        Task<PersonViewModel> GetPersonById(Guid personId);
    }
}
