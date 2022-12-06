using MediatR;
using Microsoft.AspNetCore.Mvc;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.KundersDtos;
using Unik_TaskManagement.Application.Features.Stamdata.Kunder.Queries.GetAll;
using Unik_TaskManagement.Application.Features.Stamdata.Medarbejder.Queries.GetAll;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Unik_TaskManagement.Api.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class MedarbejderController : ControllerBase
	{
		private readonly IMediator _mediator;
		public MedarbejderController ( IMediator mediator )
		{
			this._mediator = mediator;
		}
		// GET: api/<MedarbejderController>
		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<List<MedarbejderVM>>> Medarbejder ( )
		{
			var dtos = await _mediator.Send(new GetMedarbejdeListQuery( ));
			return Ok(dtos);
		}

		// GET api/<MedarbejderController>/5
		[HttpGet("{id}")]
		public string Get ( int id )
		{
			return "value";
		}

		// POST api/<MedarbejderController>
		[HttpPost]
		public void Post ( [FromBody] string value )
		{
		}

		// PUT api/<MedarbejderController>/5
		[HttpPut("{id}")]
		public void Put ( int id, [FromBody] string value )
		{
		}

		// DELETE api/<MedarbejderController>/5
		[HttpDelete("{id}")]
		public void Delete ( int id )
		{
		}
	}
}
