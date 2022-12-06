using MediatR;
using Microsoft.AspNetCore.Mvc;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.KundersDtos;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetAll;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetDetails;
using Unik_TaskManagement.Application.Features.Stamdata.Projects.Queries.GetAll;
using Unik_TaskManagement.Application.Features.Stamdata.Projects.Queries.GetDetails;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unik_TaskManagement.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProjectController : ControllerBase
	{
		private readonly IMediator _mediator;
		public ProjectController ( IMediator mediator )
		{
			this._mediator = mediator;
		}

		// GET: api/<ProjectController>
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<List<ProjectVieModel>>> Project ( )
		{
			var dtos = await _mediator.Send(new GetAllProjectsQuery( ));
			return Ok(dtos);
		}

		// GET api/<ProjectController>/5
		[HttpGet("{id:Guid}")]
		public async Task<ActionResult<ProjectDetailVieModel>> GetById ( Guid id )
		{
			var getEventDetailQuery = new GetProjectDetailQuery( ) { ProjectId=id };
			return Ok(await _mediator.Send(getEventDetailQuery));
		}

		// POST api/<ProjectController>
		[HttpPost]
		public void Post ( [FromBody] string value )
		{
		}

		// PUT api/<ProjectController>/5
		[HttpPut("{id}")]
		public void Put ( int id, [FromBody] string value )
		{
		}

		// DELETE api/<ProjectController>/5
		[HttpDelete("{id}")]
		public void Delete ( int id )
		{
		}
	}
}
