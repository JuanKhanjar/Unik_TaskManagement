using MediatR;
using Microsoft.AspNetCore.Mvc;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.KundersDtos;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetAll;
using Unik_TaskManagement.Application.Features.Stamdata.Opgaver.Queries.GetAll;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unik_TaskManagement.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OpgaverController : ControllerBase
	{
		private readonly IMediator _mediator;
		public OpgaverController ( IMediator mediator )
		{
			this._mediator = mediator;
		}
		// GET: api/<OpgaverController>
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<List<OpgaverVM>>> Opgaver ( )
		{
			var dtos = await _mediator.Send(new GetOpgaverListQuery( ));
			return Ok(dtos);
		}

		// GET api/<OpgaverController>/5
		[HttpGet("{id}")]
		public string Get ( int id )
		{
			return "value";
		}

		// POST api/<OpgaverController>
		[HttpPost]
		public void Post ( [FromBody] string value )
		{
		}

		// PUT api/<OpgaverController>/5
		[HttpPut("{id}")]
		public void Put ( int id, [FromBody] string value )
		{
		}

		// DELETE api/<OpgaverController>/5
		[HttpDelete("{id}")]
		public void Delete ( int id )
		{
		}
	}
}
