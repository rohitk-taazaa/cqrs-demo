using Demo.Core.Commands;
using Demo.Core.Data;
using Demo.Core.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo.Core.CommandHandler
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, bool>
    {
        private readonly IRepository<Person> personRepository;

        public CreatePersonCommandHandler(IRepository<Person> personRepository)
        {
            this.personRepository = personRepository;
        }
        public async Task<bool> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var personDomain = new Person();
            personDomain.LName = request.Lname;
            personDomain.FName = request.Fname;
            await this.personRepository.SaveChangesAsync(personDomain);
            return true;
        }
    }
}
