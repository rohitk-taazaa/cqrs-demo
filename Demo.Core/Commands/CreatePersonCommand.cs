using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Commands
{
    public class CreatePersonCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}
