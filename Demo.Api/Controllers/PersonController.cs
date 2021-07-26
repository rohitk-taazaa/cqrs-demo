using Demo.Core.Commands;
using Demo.Core.Contracts;
using Demo.Core.Model;
using Demo.Core.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        private readonly IMediator _dispatcher;

        public PersonController(IPersonService personService, IMediator dispatcher)
        {
            _personService = personService;
            _dispatcher = dispatcher;
        }
        [HttpGet]
        public async Task<List<PersonViewModel>> Index()
        {
            //var data = _personService.GetAllPerson();
            var data = await _dispatcher.Send(new GetPersonListQuery());
            return data;
        }
        [HttpPost]
        public async Task<IActionResult> AddPerson(PersonEditModel model)
        {
            // var data = await _personService.AddNewPerson(model);
            var data = await _dispatcher.Send(new CreatePersonCommand { Fname = model.FName, Lname = model.LName, Id = model.Id });
            return Ok(data);
        }
    }
}
