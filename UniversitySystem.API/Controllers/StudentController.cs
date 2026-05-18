using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversitySystem.Core.Features.Students.Queries.Models;

namespace UniversitySystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("/student/getlist")]
        public async Task<IActionResult> GetStudentList()
        {
            var Response = await _mediator.Send(new GetStudentListQuery());
            return Ok(Response);

        }
    }
}
